using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NexusLabs.MicrosoftStoreInstaller
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            InstallApp();
        }

        private void InstallApp()
        {
            btnInstall.Enabled = false;
            tbPID.Enabled = false;

            Dictionary<string, string> nameValueCollection = new Dictionary<string, string>();
            List<string> types = new List<string> { "appx", "msix", "appxbundle", "msixbundle" };
            string requestUri = "https://store.rg-adguard.net/api/GetFiles";
            string address = "";

            nameValueCollection.Add("type", "ProductId");
            nameValueCollection.Add("url", this.tbPID.Text);
            nameValueCollection.Add("ring", "Retail");
            nameValueCollection.Add("lang", "en-US");

            using (HttpClient httpClient = new HttpClient())
            {
                string result = RemoveScriptAndStyle(httpClient.PostAsync(requestUri, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)nameValueCollection)).Result.Content.ReadAsStringAsync().Result);

                foreach (string type in types)
                {
                    Console.WriteLine("Trying: " + type);

                    try
                    {
                        MatchCollection matchCollection = new Regex("(http).*(" + type + ")").Matches(result);
                        int length = matchCollection[0].Value.IndexOf("\"");
                        if (length != -1)
                            address = matchCollection[0].Value.Substring(0, length);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Could not find type: " + type);
                    }
                }

                string file = Path.GetTempPath() + "\\temp.appxbundle";

                using (WebClient webClient = new WebClient())
                    webClient.DownloadFile(address, file);

                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddScript("Add-AppxPackage \"" + file + "\" | Out-String");
                    Collection<PSObject> PSOutput = powerShell.Invoke();
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PSObject pSObject in PSOutput)
                        stringBuilder.AppendLine(pSObject.ToString());

                    File.Delete(file);

                    btnInstall.Enabled = true;
                    tbPID.Enabled = true;

                    if (stringBuilder.ToString() == "")
                    {
                        MessageBox.Show("Installed " + tbPID.Text, "Microsoft Store Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to install " + tbPID.Text, "Microsoft Store Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string RemoveScriptAndStyle(string HTML)
        {
            string pattern = "<(script|style)\\b[^>]*?>.*?</\\1>";
            return Regex.Replace(HTML, pattern, "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }
    }
}

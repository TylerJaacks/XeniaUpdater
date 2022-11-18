using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

using XeniaUpdater.Source;

namespace XeniaUpdater.Forms
{
    public partial class Main : Form
    {
        private string _masterZipPath;
        private string _canaryZipPath;
        private string _canaryExZipPath;

        private readonly Settings _settings;

        public Main()
        {
            InitializeComponent();

            _settings = new Settings();

            Util.StartupTasks(_settings);
        }

        private void UpdateXenia(string folderName, string url, string zipFullName, string exeName)
        {
            ToggleButtons(true);

            Util.CreateFolders(folderName);
            Util.PreUpdateTask(folderName, zipFullName, exeName);

            if (Util.InternetAvailable())
            {
                DownloadFile(url, zipFullName, folderName);
            }
            else
            {
                MessageBox.Show(@"Could not ping AppVeyor. Please check your internet connection.");
            }
        }

        private void DownloadFile(string downloadUrl, string downloadLocation, string extractLocation)
        {
            ToggleButtons(false);

            using (var webClient = new WebClient())
            {
                // TODO: Probably put this in %TEMP% and delete it after download.

                webClient.DownloadFileAsync(new Uri(downloadUrl), downloadLocation);

                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WcDownloadProgressChanged);

                void WcDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
                {
                    progressBar.Value = e.ProgressPercentage;
                    percentageLabel.Text = $@"{progressBar.Value}%";

                    if (progressBar.Value == 100)
                    {
                        ToggleButtons(true);

                        Util.ExtractBuild(extractLocation, downloadLocation);
                    }
                }
                webClient.Dispose();

            }
        }

        private void ToggleButtons(bool enabled)
        {
            masterUpdateButton.Enabled = enabled;
            canaryUpdateButton.Enabled = enabled;
            canaryExUpdateButton.Enabled = enabled;
        }

        private void updateMasterButton_Click(object sender, EventArgs e)
        {
            const string url = "https://ci.appveyor.com/api/projects/benvanik/xenia/artifacts/xenia_master.zip?branch=master&job=Configuration%3A%20Release&pr=false";

            _masterZipPath = Path.Combine(Path.GetTempPath() + "xenia_master.zip");

            UpdateXenia(_settings.MasterPath, url, _masterZipPath, "xenia.exe");
        }

        private void updateCanaryButton_Click(object sender, EventArgs e)
        {
            const string url = "https://github.com/xenia-canary/xenia-canary/releases/latest/download/xenia_canary.zip";

            _canaryZipPath = Path.Combine(Path.GetTempPath() + "xenia_canary.zip");

            UpdateXenia(_settings.CanaryPath, url, _canaryZipPath, "xenia_canary.exe");
        }

        private void updateEx_Click(object sender, EventArgs e)
        {
            const string url = "https://ci.appveyor.com/api/projects/chris-hawley/xenia-canary/artifacts/xenia_canary.zip?branch=canary_experimental&job=Configuration:%20Release&pr=false";

            _canaryExZipPath = Path.Combine(Path.GetTempPath() + "xenia_canary.zip");

            UpdateXenia(_settings.CanaryExPath, url, _canaryExZipPath, "xenia_canary.exe");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            var aboutDialog = new AboutDialog();

            aboutDialog.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingsDialog();

            settingsDialog.ShowDialog();
        }
    }
}
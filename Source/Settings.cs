using System;
using System.IO;

namespace XeniaUpdater.Source
{
    public class Settings
    {
        public string MasterPath { get; set; }
        public string CanaryPath { get; set; }
        public string CanaryExPath { get; set; }

        public Settings()
        {

        }

        public void LoadSettings()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var filePath = Path.Combine(appDataFolder, @"XeniaUpdater\Settings.ini");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var split = line.Split('=');

                    switch (split[0])
                    {
                        case "MasterPath":
                            MasterPath = split[1];
                            break;
                        case "CanaryPath":
                            CanaryPath = split[1];
                            break;
                        case "CanaryExPath":
                            CanaryExPath = split[1];
                            break;
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(appDataFolder, @"XeniaUpdater\"));

                File.Create(filePath).Dispose();

                var lines = new string[]
                {
                    "[Settings]",
                    "MasterPath=",
                    "CanaryPath=",
                    "CanaryExPath="
                };

                File.WriteAllLines(filePath, lines);
            }
        }

        public void SaveSettings()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var filePath = Path.Combine(appDataFolder, @"XeniaUpdater\Settings.ini");

            Directory.CreateDirectory(Path.Combine(appDataFolder, @"XeniaUpdater\"));

            File.Create(filePath).Dispose();

            var lines = new string[]
            {
                "[Settings]",
                "MasterPath=" + this.MasterPath,
                "CanaryPath=" + this.CanaryPath,
                "CanaryExPath=" + this.CanaryExPath
            };

            File.WriteAllLines(filePath, lines);
        }
    }
}
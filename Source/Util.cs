﻿using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace XeniaUpdater.Source
{
    internal static class Util
    {
        public static void CreateFolders(string folderName)
        {
            try
            {
                Directory.CreateDirectory(folderName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void ExtractBuild(string folderName, string zipName)
        {
            try
            {
                File.Delete($"{folderName}/LICENSE");
                File.Delete($"{folderName}/xenia.exe");
                File.Delete($"{folderName}/xenia_canary.exe");
                File.Delete($"{folderName}/xenia.pdb");

                ZipFile.ExtractToDirectory($"{zipName}", folderName);

                File.Delete($"{folderName}/LICENSE");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void PreUpdateTask(string folderName, string zipName, string executableName)
        {
            var pdbName = executableName.Remove(executableName.Length - 4) + ".pdb";

            try
            {
                File.Delete($"{folderName}/LastUpdate/{zipName}");
                File.Delete($"{folderName}/{executableName}");
                File.Delete($"{folderName}/LICENSE");
                File.Delete($"{folderName}/xenia.log");
                File.Delete($"{folderName}/{executableName}");
                File.Delete($"{folderName}/{pdbName}");
                File.Delete($"{folderName}/{pdbName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void StartupTasks()
        {
            Program.Settings.LoadSettings();
        }

        public static bool InternetAvailable()
        {
            try
            {
                using (var client = new WebClient())

                using (client.OpenRead("http://appveyor.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

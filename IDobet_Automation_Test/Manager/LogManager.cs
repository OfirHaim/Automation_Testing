using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.Manager
{
    public class LogManager
    {
        public enum elogLevel
        {
            Debug,
            Info,
            Warn,
            Error
        }

        public string ImageFolder => $"{ConfigurationManager.AppSettings["Path"]}\\{ConfigurationManager.AppSettings["Version"]}\\{ConfigurationManager.AppSettings["failImagesPath"]}";

        private static LogManager _instance { get; set; }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private LogManager()
        {

        }

        public static LogManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogManager();
                    LogManager.Instance.CreateFolder(Instance.ImageFolder);
                }
                return _instance;
            }
        }

        private void CreateFolder(string path)
        {
            var di = new DirectoryInfo(path);
            if (!di.Exists)
                di.Create();
        }

        public void WriteToLog(elogLevel level, string logMessage, Exception ex = null)
        {
            switch (level)
            {
                case elogLevel.Debug:
                    if (ex == null)
                    {
                        log.Debug(logMessage);
                        break;
                    }
                    else if (ex != null)
                    {
                        log.Debug(ex);
                    }
                    break;

                case elogLevel.Error:
                    if (ex == null)
                    {
                        log.Debug(logMessage);
                        break;
                    }
                    else if (ex != null)
                    {
                        log.Debug(ex);
                    }
                    break;

                case elogLevel.Info:
                    if (ex == null)
                    {
                        log.Debug(logMessage);
                        break;
                    }
                    else if (ex != null)
                    {
                        log.Debug(ex);
                    }
                    break;

                case elogLevel.Warn:
                    if (ex == null)
                    {
                        log.Debug(logMessage);
                        break;
                    }
                    else if (ex != null)
                    {
                        log.Debug(ex);
                    }
                    break;
            }
        }
    }
}


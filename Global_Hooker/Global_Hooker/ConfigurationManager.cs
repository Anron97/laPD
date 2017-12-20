using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GodSharp.Encryption;

namespace Global_Hooker
{
    class ConfigurationManager
    {
        public string EmailAddresser { get; set; }
        public string EmailAddressee { get; set; }
        public string EmailPassword { get; set; }
        public string HiddenMode { get; set; }
        public int MaxFileSize { get; set; }

        private static ConfigurationManager _instace;

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new ConfigurationManager();
                return _instace;
            }
        }

        private ConfigurationManager()
        {
            try
            {
                EmailAddressee = AES.Decrypt(Properties.Settings.Default.EmailAddressee, "password");
                EmailAddresser = AES.Decrypt(Properties.Settings.Default.EmailAddresser, "password");
                EmailPassword = AES.Decrypt(Properties.Settings.Default.EmailPassword, "password");
                HiddenMode = AES.Decrypt(Properties.Settings.Default.HiddenMode, "password");
                MaxFileSize = int.Parse(AES.Decrypt(Properties.Settings.Default.MaxFileSize, "password"));
                if (MaxFileSize <= 0)
                {
                    MaxFileSize = 1024;
                }
            }
            catch (Exception ex)
            {
                EmailAddressee = "youEmail@gmail.com";
                EmailAddresser = "addresserEmail@gmail.com";
                EmailPassword = "password";
                HiddenMode = "False";
                MaxFileSize = 1024;
            }
        }

        public void SaveConfig()
        {
            var settings = Properties.Settings.Default;
            settings.EmailAddressee = AES.Encrypt(EmailAddressee, "password");
            settings.EmailAddresser = AES.Encrypt(EmailAddresser, "password");
            settings.EmailPassword = AES.Encrypt(EmailPassword, "password");
            settings.HiddenMode = AES.Encrypt(HiddenMode, "password");
            settings.MaxFileSize = AES.Encrypt(MaxFileSize.ToString(), "password");
            settings.Save();
        }
    }
}

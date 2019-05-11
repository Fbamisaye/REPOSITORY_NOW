using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIT_TEST_TWO.Con_figuration;
using UNIT_TEST_TWO.Configuration;
using UNIT_TEST_TWO.Interfaces;
using UNIT_TEST_TWO.Settings;

namespace UNIT_TEST_TWO.Configuration
{

    public class AppConfigReader : ICongfig
    {
        public BrowserTypes GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserTypes) Enum.Parse(typeof(BrowserTypes), browser);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}

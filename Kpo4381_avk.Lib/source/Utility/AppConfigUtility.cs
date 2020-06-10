using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4381_avk.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name) 
        {
            if(ConfigurationManager.AppSettings[name] != null)
            {
                return Convert.ToString(ConfigurationManager.AppSettings[name]);
            }
            else
            {
                return "";
            }
        }
    }
}

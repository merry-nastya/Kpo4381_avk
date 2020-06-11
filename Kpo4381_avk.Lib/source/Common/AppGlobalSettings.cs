using Kpo4381_avk.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        public static string logPath
        {
            get { return _logPath; }
        }

        private static string _dataFileName;
        public static string dataFileName
        {
            get { return _dataFileName; }
        }

        private static string _searchProjectFactory;
        public static string searchProjectFactory
        {
            get { return _searchProjectFactory; }
        }

        private static string _saveFileName;
        public static string saveFileName
        {
            get { return _saveFileName; }
        }
        public static void Initialize()
        {
            AppConfigUtility appConfigUtility = new AppConfigUtility();
            _logPath = appConfigUtility.AppSettings("logPath");
            _dataFileName = appConfigUtility.AppSettings("dataFileName");
            _searchProjectFactory = appConfigUtility.AppSettings("typeFactory");
            _saveFileName = appConfigUtility.AppSettings("saveFileName");
        }

    }
}

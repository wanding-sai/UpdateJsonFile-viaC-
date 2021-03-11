using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class UtilityConst
    {
        public static string RuleName => ConfigurationManager.AppSettings["RuleName"];
        public static bool IsEnabled => bool.Parse(ConfigurationManager.AppSettings["IsEnabled"]);
        public static string RuleType => ConfigurationManager.AppSettings["RuleType"];
        public static string BType => ConfigurationManager.AppSettings["BType"];
        public static string[] PrefixMatch = ConfigurationManager.AppSettings["PrefixMatch"].Split(',');
        public static int CreateDays => int.Parse(ConfigurationManager.AppSettings["CreateDays"]);
        public static int UpdateDays => int.Parse(ConfigurationManager.AppSettings["UpdateDays"]);
        public static int DeleteDays => int.Parse(ConfigurationManager.AppSettings["DeleteDays"]);
    }
}

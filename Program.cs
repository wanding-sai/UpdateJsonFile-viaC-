using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            UpdateRules(UtilityConst.RuleName, UtilityConst.IsEnabled, UtilityConst.RuleType, UtilityConst.BType, UtilityConst.PrefixMatch,
                UtilityConst.CreateDays, UtilityConst.UpdateDays, UtilityConst.DeleteDays);
            
            //string json = UpdateRules(UtilityConst.RuleName, UtilityConst.IsEnabled, UtilityConst.RuleType, UtilityConst.BType, UtilityConst.PrefixMatch,
            //    UtilityConst.CreateDays, UtilityConst.UpdateDays, UtilityConst.DeleteDays);
            //Console.WriteLine(json);
            Console.ReadKey();
        }
        private static string UpdateRules(string ruleName, bool isEnbaled, string ruleType, string bType, string[] prefixMatch, int createDays, int updateDays, int deleteDays)
        {
            var jsonString = File.ReadAllText(@"D:\2021\test.json");
            var rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonString);
            
            string id = rootobject.id;
            string name = rootobject.name;
            string type = rootobject.type;

            Properties properties = rootobject.properties;
            Policy policy = properties.policy;

            Rule[] rules = policy.rules;
            foreach (Rule rule in rules)
            {
                rule.name = ruleName;
                rule.enabled = isEnbaled;
                rule.type = ruleType;
                Definition definition = rule.definition;
                Filters filters = definition.filters;
                Actions actions = definition.actions;

                filters.bTypes = bType;
                filters.prefixMatch = prefixMatch;
                Base _base = actions._base;
                Create create = _base.create;
                Update update = _base.update;
                Delete delete = _base.delete;

                create.days = createDays;
                update.days = updateDays;
                delete.days = deleteDays;
            }

            string json = JsonConvert.SerializeObject(rootobject, Formatting.Indented);
            Console.WriteLine(json);
            return json;
        }
    }
}

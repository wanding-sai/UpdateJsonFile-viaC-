using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    public class Rootobject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public Policy policy { get; set; }
    }

    public class Policy
    {
        public Rule[] rules { get; set; }
    }

    public class Rule
    {
        public bool enabled { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public Definition definition { get; set; }
    }

    public class Definition
    {
        public Filters filters { get; set; }
        public Actions actions { get; set; }
    }

    public class Filters
    {
        public string bTypes { get; set; }
        public string[] prefixMatch { get; set; }
    }

    public class Actions
    {
        public Base _base { get; set; }
    }

    public class Base
    {
        public Create create { get; set; }
        public Update update { get; set; }
        public Delete delete { get; set; }
    }

    public class Create
    {
        public int days { get; set; }
    }

    public class Update
    {
        public int days { get; set; }
    }

    public class Delete
    {
        public int days { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_Automation_CAW.Pages
{
    public class Constants
    {
        public static string CurrentUrl = " https://testpages.herokuapp.com/styled/tag/dynamic-table.html ";
        public static List<Dictionary<string, string>> GetTestData()
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();
            Dictionary<string, string> dic3 = new Dictionary<string, string>();
            Dictionary<string, string> dic4 = new Dictionary<string, string>();
            Dictionary<string, string> dic5 = new Dictionary<string, string>();

            dic1.Add("name", "Bob");
            dic1.Add("age", "20");
            dic1.Add("gender", "male");

            list.Add(dic1);

            dic2.Add("name", "George");
            dic2.Add("age", "42");
            dic2.Add("gender", "male");
            list.Add(dic2);

            dic3.Add("name", "Sara");
            dic3.Add("age", "42");
            dic3.Add("gender", "female");
            list.Add(dic3);

            dic4.Add("name", "Conor");
            dic4.Add("age", "40");
            dic4.Add("gender", "male");
            list.Add(dic4);


            dic5.Add("name", "Jennifer");
            dic5.Add("age", "42");
            dic5.Add("gender", "female");
            list.Add(dic5);

            return list;
        }
    }
}

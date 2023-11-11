using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace SDET_Automation_CAW.Pages
{
    public class  Common_Methods:Base_Page
    {
     
        //Xpath
        public static By Tablexapth = By.XPath("//summary[text()='Table Data']/parent::details");
        public static By VisbleBox = By.XPath("//textarea[@id='jsondata']");
        public static By RefreshButtonxapth = By.XPath("//button[@id='refreshtable'] ");

        //Element
        public static IWebElement table { get { return driver.FindElement(Tablexapth); } }
        public static IWebElement refresh_Button { get { return driver.FindElement(RefreshButtonxapth); } }
        public static IWebElement box { get { return driver.FindElement(VisbleBox); } }

        public static void UpdateTableData(List<Dictionary<string,string>> inputText)
        {
            var result = JsonConvert.SerializeObject(inputText);
            Thread.Sleep(1000);
            table.Click();
            Thread.Sleep(1000);
            box.Clear();
            Thread.Sleep(1000);
            box.SendKeys(result.ToString());
            Thread.Sleep(1000);
            refresh_Button.Click();
            Thread.Sleep(2000);

        }
        // Json Formate

      
       public static void OpenUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        public static List<Dictionary<string,string>> Read_tableData()
        {
            var rows = driver.FindElements(By.XPath("//table[@id='dynamictable']//tr"));

            List<string> KEYS = new List<string>();

            var rowKEYSs = driver.FindElements(By.XPath("//table[@id='dynamictable']//tr[1]//th"));
            for (int k = 1; k <= rowKEYSs.Count(); k++)
            {
                IWebElement columsData = driver.FindElement(By.XPath(string.Format("//table[@id='dynamictable']//tr[1]/th[{0}]", k)));
                KEYS.Add(columsData.Text.ToString());
            }

            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            for (int i = 2; i <= rows.Count(); i++)
            {
                Dictionary<string, string> dic1 = new Dictionary<string, string>();

                string coooo = string.Format("//table[@id='dynamictable']//tr[{0}]//th", i);

                var colums = driver.FindElements(By.XPath(string.Format("//table[@id='dynamictable']//tr[{0}]//td", i)));

                for (int j = 1; j <= colums.Count(); j++)
                {
                    IWebElement columsData = driver.FindElement(By.XPath(string.Format("//table[@id='dynamictable']//tr[{0}]//td[{1}]", i, j)));
                    string dddddd = columsData.Text.ToString();
                    dic1.Add(KEYS[j - 1], columsData.Text.ToString());
                }
                list.Add(dic1);
            }
           
            return list;
        }
        public static bool CompareTwoListOfDict(List<Dictionary<string, string>> BaseList, List<Dictionary<string, string>> SourceList)
        {
            bool isdataEquls = true;

            if (BaseList.Count == SourceList.Count)
            {
                for (int i = 0; i < BaseList.Count; i++)
                {
                    Dictionary<string, string> dic1 = BaseList[i];
                    Dictionary<string, string> dic2 = SourceList[i];

                    if (dic1.Count == dic2.Count)
                    {
                        // isdataEquls= dic1.Equals(dic2);
                        isdataEquls = dic1.OrderBy(kv => kv.Key).SequenceEqual(dic1.OrderBy(kv => kv.Key));
                    }
                    else
                    {
                        isdataEquls = false;
                        break;
                    }
                }
            }
            else
            {
                isdataEquls = false;
            }
            return isdataEquls;
        }


    }
}

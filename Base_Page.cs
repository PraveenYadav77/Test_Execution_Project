using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SDET_Automation_CAW.Pages
{
    public  class Base_Page
    {

        public static WebDriver driver;
        public void OpenChromeDriver()
        {
            driver = new ChromeDriver();
        }

        public void CloseChrome1()
        {
            driver.Close();
            driver.Quit();
        }

    }
}

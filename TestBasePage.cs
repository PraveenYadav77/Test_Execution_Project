using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDET_Automation_CAW.Pages;

namespace TestProject1
{
    public class TestBasePage :Base_Page
    {

        public void OpneSriver()
        {
            OpenChromeDriver();
        }

        public void CloseChorme()
        {
            CloseChrome1();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class UploadPics
    {
        public void Submit(IWebDriver driver, string XPATH,string url)
        {
            //driver.Url = url;
            driver.FindElement(By.XPath(XPATH)).SendKeys("C:\\Users\\wukas\\Desktop\\Untitled.png");
        }
    }
}

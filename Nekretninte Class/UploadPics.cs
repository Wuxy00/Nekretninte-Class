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
        public void Submit(IWebDriver driver) => driver.FindElement(By.XPath("//*[@id='media']/div/div/div[1]/div[1]/div[1]/button")).Click();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class UploadPicture
    {
        string url = "https://www.4zida.rs/novi-oglas/prodaja";

        public void Setup(IWebDriver driver) => driver.Url = url;

        public void Procced(IWebDriver driver, string[] paths,int n)
        {
            for (int i = 0; i < n; i++)
                driver.FindElement(By.ClassName("btn red-affirmative upload-button")).SendKeys('"' + paths[i] + '"');
        }
        public void Submit(IWebDriver driver) => driver.FindElement(By.ClassName("btn red - affirmative upload - button")).Click();
    }
}

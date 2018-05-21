using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Nekretninte_Class
{
    class GoForward
    {
        IWebDriver driver;
        string url = "https://www.4zida.rs/novi-oglas/prodaja";
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }
    }
}

/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : LNekretnine365.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login Nekretnine365.com
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class LNekretnine365NOTUSED
    {
        string url = "https://www.nekretnine365.com/login.html";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procede(IWebDriver driver, string username, string password)
        {
            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/input[2]")).SendKeys(username);
            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/input[3]")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/div[2]/input")).Click();
        }
    }
}

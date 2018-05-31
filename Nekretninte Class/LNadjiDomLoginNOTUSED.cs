/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : NadjiDom.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on nadjidom.com
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class LNadjiDomLogin
    {
        string url = "http://www.nadjidom.com/sr/login";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procced(IWebDriver driver, string username, string password)
        {
            //*[@id="login_username"]
            //*[@id='login_password']
            driver.FindElement(By.Id("login_username")).SendKeys(username);
            driver.FindElement(By.Id("login_password")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[4]/input")).Click();
        }
    }
}

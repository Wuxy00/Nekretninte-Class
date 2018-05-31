/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : LNekretnineRs.cs
 *
 * Created By  : Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login nekretnine.rs
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class LNekretnineRs
    {
        string url = "https://www.nekretnine.rs/";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Proceed(IWebDriver driver, string password) //Static username, no email...
        {          
            PublicVar.WaitUntilElementExists(driver, By.XPath("//*[@id='ajax_login']/div/a"), 15).Click();           
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement div = driver.FindElement(By.XPath("//*[@id='loginDialog']"));          
            IWebElement usernameField = PublicVar.WaitUntilElementExists(driver, By.XPath("//*[@id='loginUsername']"), 5);
            
            usernameField.SendKeys("vukasinlegenda");
            div.FindElement(By.XPath("//*[@id='loginPassword']")).SendKeys(password);
            div.FindElement(By.XPath("//*[@id='btnLogin']")).Click();            
        }        
    }
}

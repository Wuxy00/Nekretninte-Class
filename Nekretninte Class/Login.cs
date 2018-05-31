/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : Login.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on all
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;
using System;


namespace Nekretninte_Class
{
    class Login
    {
        public void Setup(IWebDriver driver,string url)
        {
            driver.Url = url;
        }
        public void End(IWebDriver driver)
        {
            driver.Close();
        }
        public void Procced(IWebDriver driver, string textUser, string textPass, string XPathU, string XPathP, string XPathB)
        {
            driver.FindElement(By.XPath(XPathU)).SendKeys(textUser);
            driver.FindElement(By.XPath(XPathP)).SendKeys(textPass);
            driver.FindElement(By.XPath(XPathB)).Click();
        }
        public void ProccedByPass(IWebDriver driver, string textUser, string textPass, string XPathU, string XPathP, string XPathB, string XPathPrijava)
        {
            driver.FindElement(By.XPath(XPathU)).SendKeys(textUser);
            driver.FindElement(By.XPath(XPathP)).SendKeys(textPass);
            string num1 = driver.FindElement(By.XPath("//*[@id='spm-chk-prijava']/img[1]")).GetAttribute("src");
            string num2 = driver.FindElement(By.XPath("//*[@id='spm-chk-prijava']/img[3]")).GetAttribute("src");
            int IntNum1 = Convert.ToInt32(num1.Substring(64, 1));
            int IntNum2 = Convert.ToInt32(num2.Substring(64, 1));
            driver.FindElement(By.XPath("//*[@id='integrityPrijavaTxt']")).SendKeys(Convert.ToString(IntNum1 + IntNum2));
            driver.FindElement(By.XPath(XPathB)).Click();
        }
        public void ProccedID(IWebDriver driver, string textUser, string textPass, string XPathU, string XPathP, string IdB)
        {
            driver.FindElement(By.XPath(XPathU)).SendKeys(textUser);
            driver.FindElement(By.XPath(XPathP)).SendKeys(textPass);
            driver.FindElement(By.Id(IdB)).Click();
        }
        public void ProccedByPassDica(IWebDriver driver, string textPass)
        {
            driver.FindElement(By.XPath("//*[@id='ajax_login']/div/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//*[@id='loginUsername']")).SendKeys("vukasinlegenda");
            driver.FindElement(By.XPath("//*[@id='loginPassword']")).SendKeys(textPass);
            driver.FindElement(By.XPath("//*[@id='btnLogin']")).Click();
        }
    }
}


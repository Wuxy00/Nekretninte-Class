﻿/*****************************************************************************
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
    class NadjiDomLogin
    {
        string url = "http://www.nadjidom.com/sr/login";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
            driver.Navigate().GoToUrl(url);
        }
        public void Procced(IWebDriver driver, string username, string password)
        {
            //MOZDA TREBA //driver.Manage().Window.Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 10, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - 10);
            driver.FindElement(By.Id("login_username")).SendKeys(username);
            driver.FindElement(By.Id("login_password")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[4]/input")).Click();
        }
    }
}

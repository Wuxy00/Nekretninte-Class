/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : LMojTrg.cs
 *
 * Created By  : Danilo Milošević
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on mojtrg.rs
 *               
 *
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class LMojTrg
    {
        string url = "https://www.mojtrg.rs/Dispatcher/Render?incView=~%2FViews%2FAccount%2FSignIn.cshtml";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procede(IWebDriver driver, string username, string password)
        {
            driver.FindElement(By.Id("Email")).SendKeys(username);
            driver.FindElement(By.Id("Password")).SendKeys(password);
            driver.FindElement(By.XPath("/html/body/section/div[1]/div/div[1]/div[1]/form/div[2]/div/div[1]/input")).Submit();
        }
    }
}

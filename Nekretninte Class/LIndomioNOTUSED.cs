/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : LIndomio.cs
 *
 * Created By  : Danilo Milošević
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on indomio.rs
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
    class LIndomio
    {
        string url = "https://crm.indomio.com/sr/login";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procede(IWebDriver driver, string username, string password)
        {
            //*[@id='fieldPassword']
            //*[@id="fieldEmail"]
            //*[@id='form-login']/button
            driver.FindElement(By.Id("fieldEmail")).SendKeys(username);
            driver.FindElement(By.Id("fieldPassword")).SendKeys(password);
            driver.FindElement(By.CssSelector("#form-login > button")).Submit();
        }
    }
}

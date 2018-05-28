/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FNekretnineRs.cs
 *
 * Created By  : Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill nekretnine.rs
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Nekretninte_Class
{
    class FNekretnineRs
    {
        public void Proceed(IWebDriver driver)
        {
            driver.Url = "https://www.nekretnine.rs/member/Insertion/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PublicVar.WaitUntilElementExists(driver, By.XPath("//*[@id='instructionWrapper']/div[2]/a"), 20).Click();
        }
    }
}

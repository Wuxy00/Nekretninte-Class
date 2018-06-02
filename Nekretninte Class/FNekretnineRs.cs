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
        public void Setup(IWebDriver driver)
        {
            driver.Url = "https://www.nekretnine.rs/member/Insertion/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='instructionWrapper']/div[2]/a")));
            driver.FindElement(By.XPath("//*[@id='instructionWrapper']/div[2]/a")).Click();
        }
        public void Proceed(IWebDriver driver, bool izdavanje)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='3000']")));
            if (izdavanje) driver.FindElement(By.XPath("//*[@id='3000']")).Click();
            driver.FindElement(By.XPath("//*[@id='city']")).SendKeys("Niš");
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='ui - id - 2']")));
            driver.FindElement(By.XPath("//*[@id='ui - id - 41']")).Click();
        }
    }
}

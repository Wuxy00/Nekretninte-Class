
/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : PublicVar.cs
 *
 * Created By  : Vukašin Stamenković & Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Public variable IWebDriver starting only one Chrome tab for whole Program.
 * WaitUntilElementExists waits for the element to be found.
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class PublicVar
    {
        //public static IWebDriver driver = new ChromeDriver(); // 4 zida
        //public static IWebDriver driver1 = new ChromeDriver(); // srbija-nekretnine
        //public static IWebDriver driver2 = new ChromeDriver(); // nadji dom
        //public static IWebDriver driver3 = new ChromeDriver(); // retalica
        //public static IWebDriver driver4 = new ChromeDriver(); // mojtrg
        public static IWebDriver driver5 = new ChromeDriver(); // indomio
        //public static IWebDriver driver6 = new ChromeDriver(); // Nekretnine365
        //public static IWebDriver driver7 = new ChromeDriver(); // Nekretnine.rs

        public static IWebElement WaitUntilElementExists(IWebDriver driverZ, By elementLocator, int timeout) //Wait until the element is found.
        {
            try
            {
                var wait = new WebDriverWait(driverZ, TimeSpan.FromSeconds(timeout));
                //return wait.Until(ExpectedConditions.ElementExists(elementLocator));//BUGFIX
                return null;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
        public static void ScrollUntilVisible(IWebDriver driverZ,IWebElement NonVisibleElement,bool centriran)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driverZ;
            if(centriran)js.ExecuteScript("arguments[0].scrollIntoView(true);", NonVisibleElement);
            else js.ExecuteScript("arguments[0].scrollIntoView(false);", NonVisibleElement);
        }
    }
}

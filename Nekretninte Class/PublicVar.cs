
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
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutoItX3Lib;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class PublicVar
    {
        public static IWebDriver driver = new ChromeDriver(); // 4 zida
        //public static IWebDriver driver1 = new ChromeDriver(); // srbija-nekretnine
        //public static IWebDriver driver2 = new ChromeDriver(); // nadji dom
        //public static IWebDriver driver3 = new ChromeDriver(); // retalica
        //public static IWebDriver driver4 = new ChromeDriver(); // mojtrg
        //public static IWebDriver driver5 = new ChromeDriver(); // indomio
        //public static IWebDriver driver6 = new ChromeDriver(); // Nekretnine365
        //public static IWebDriver driver7 = new ChromeDriver(); // Nekretnine.rs
        
        public static void ScrollUntilVisible(IWebDriver driverZ,IWebElement NonVisibleElement,bool centriran) 
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driverZ;
            if(centriran)js.ExecuteScript("arguments[0].scrollIntoView(true);", NonVisibleElement);
            else js.ExecuteScript("arguments[0].scrollIntoView(false);", NonVisibleElement);
        }
        public static void UploadPhotos(IWebDriver driverZ, By input, string[] photos) // Samo radi na tipove "input"
        {
            IWebElement dugme = driver.FindElement(input);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            int x = photos.Length;
            for (int i = 0; i < x; ++i)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(input));
                dugme.SendKeys(photos[i]);
                //wait.Until(ExpectedConditions.StalenessOf(dugme));
            }
        }
        public static void UploadPhotos(IWebDriver driverZ, int input, string[] photos) //Kad trazi sa tagom input i broj njegov
        {
            IWebElement dugme = driver.FindElements(By.TagName("input"))[input];
            int x = photos.Length;
            for (int i = 0; i < x; ++i) dugme.SendKeys(photos[i]);
        }
        public static void UploadPhotos(IWebDriver driverZ, string photo) //Upload na button
        {
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            autoIt.Send(photo);
            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");
        }        
    }
}

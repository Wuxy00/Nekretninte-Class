
/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : PublicVar.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Public variable IWebDriver starting only one Chrome tab for whole Program
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.CodeDom;

namespace Nekretninte_Class
{
    class PublicVar
    {
        public static IWebDriver driver = new ChromeDriver();
        public static IWebDriver driver1 = new ChromeDriver();
        public static IWebDriver driver2 = new ChromeDriver();
        public static IWebDriver driver3 = new ChromeDriver();
    }
}

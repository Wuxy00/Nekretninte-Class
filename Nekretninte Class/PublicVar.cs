
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

namespace Nekretninte_Class
{
    class PublicVar
    {
        public static IWebDriver driver = new ChromeDriver(); // 4 zida
        public static IWebDriver driver1 = new ChromeDriver(); // srbija-nekretnine
        public static IWebDriver driver2 = new ChromeDriver(); // nadji dom
        public static IWebDriver driver3 = new ChromeDriver(); // retalica
        public static IWebDriver driver4 = new ChromeDriver(); // mojtrg
    }
}

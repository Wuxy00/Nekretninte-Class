
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
    }
}

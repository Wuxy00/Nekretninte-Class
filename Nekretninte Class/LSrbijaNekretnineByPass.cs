/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : SrbijaNekretnineByPass.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on srbija-nekretnine.org
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class LSrbijaNekretnineByPass
    {
        string url = "https://srbija-nekretnine.org/agencija/registracija?oglas=1";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procede(IWebDriver driver, string username, string password)
        {
            driver.FindElement(By.Id("UsernameTxt")).SendKeys(username);
            driver.FindElement(By.Id("PasswordTxt")).SendKeys(password);
            string num1 = driver.FindElement(By.XPath("//*[@id='spm-chk-prijava']/img[1]")).GetAttribute("src");
            string num2 = driver.FindElement(By.XPath("//*[@id='spm-chk-prijava']/img[3]")).GetAttribute("src");
            int IntNum1 = Convert.ToInt32(num1.Substring(64,1));
            int IntNum2 = Convert.ToInt32(num2.Substring(64, 1));
            driver.FindElement(By.Id("integrityPrijavaTxt")).SendKeys(Convert.ToString(IntNum1 + IntNum2));
            driver.FindElement(By.Id("prijaviBtn")).Submit();
        }
    }
}

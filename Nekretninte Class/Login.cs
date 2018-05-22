/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : Login.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login on 4zida.rs
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;


namespace Nekretninte_Class
{
    class Login
    {
        string url = "https://www.4zida.rs/login";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void End(IWebDriver driver)
        {
            driver.Close();
        }
        public void Procced(IWebDriver driver, string textUser, string textPass)
        {
            driver.FindElement(By.Id("username")).SendKeys(textUser);
            driver.FindElement(By.Id("password")).SendKeys(textPass);
            driver.FindElement(By.Id("end-buttons")).Submit();
        }
    }
}

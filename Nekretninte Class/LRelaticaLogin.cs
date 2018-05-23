/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : RelaticaLogin.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Login Relatica.com
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class LRelaticaLogin
    {
        string url = "https://www.realitica.com/index.php?action=member_login&lng=hr";
        public void Setup(IWebDriver driver)
        {
            driver.Url = url;
        }
        public void Procede(IWebDriver driver, string username, string password)
        {
            driver.FindElement(By.XPath("//*[@id='content_holder']/form[1]/table/tbody/tr[1]/td[2]/input")).SendKeys(username);
            driver.FindElement(By.XPath("//*[@id='content_holder']/form[1]/table/tbody/tr[2]/td[2]/input")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='content_holder']/form[1]/table/tbody/tr[4]/td/input")).Submit();
        }
    }
}

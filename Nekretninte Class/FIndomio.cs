/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FIndomio.cs
 *
 * Created By  : Danilo Milošević
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill indomio.rs
 *               
 *
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class FIndomio
    {
        public void Procede(IWebDriver driver)
        {
            driver.Url = "https://crm.indomio.com/sr/editListing/create";

            var zemlja = new SelectElement(driver.FindElement(By.Id("country")));
            zemlja.SelectByValue("8");

            //driver.FindElement(By.Id("ChangeAdContactInfoCmd_Name")).SendKeys() - ako treba drugi mail
            //driver.FindElement(By.Id("ChangeAdContactInfoCmd_Phone")).SendKeys() - ako se menja brTelefona
        }
    }
}

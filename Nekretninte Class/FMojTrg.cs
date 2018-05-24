/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FMojTrg.cs
 *
 * Created By  : Danilo Milošević
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill mojtrg.rs
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
    class FMojTrg
    {
        public void Procede(IWebDriver driver)
        {
            driver.Url = "http://www.nadjidom.com/sr/my-real-estate-ads&action=add";
            driver.FindElement(By.Id("ChangeAdContactInfoCmd_IsCompany")).Click();
            
            //driver.FindElement(By.Id("ChangeAdContactInfoCmd_Name")).SendKeys() - ako treba drugi mail
            //driver.FindElement(By.Id("ChangeAdContactInfoCmd_Phone")).SendKeys() - ako se menja brTelefona
        }
    }
}

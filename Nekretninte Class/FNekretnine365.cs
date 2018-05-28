/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FNekretnine365.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill Nekretnine365.com
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
    class FNekretnine365
    {
        public void Procede(IWebDriver driver, string cbKat, string tbNaslov, string tbKvad, string cbSprat)
        {
            driver.Url = "https://www.nekretnine365.com/upis-oglasa.html";

            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("tree_area_0")));
            oSelectTip.SelectByText(cbKat);//Tip;

            driver.FindElement(By.Id("next_step")).Click();

            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/div[2]/input")).Click();

            driver.FindElement(By.XPath("//*[@id='area_title_bs']/input")).SendKeys(tbNaslov);

            driver.FindElement(By.XPath("//*[@id='css_INPUT_2']")).Click();

            driver.FindElement(By.XPath("//*[@id='sf_field_square_feet']/input")).SendKeys(tbKvad);

            driver.FindElement(By.XPath("//*[@id='sf_field_floor']/input")).SendKeys(cbSprat); // Sprat


        }
    }
}

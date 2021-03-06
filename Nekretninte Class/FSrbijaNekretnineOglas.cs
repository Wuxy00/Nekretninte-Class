﻿/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : SrbijaNekretnineOglas.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : fill on srbija-nekretnine.org
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class FSrbijaNekretnineOglas
    {
        public void Procede(IWebDriver driver,string Naslov, string DeoGrada, string m2,string Combobox1Prvi,string tbPrice,string desc,string bathroom,string terrace,string year,string Combobox2Sprat,string cbGrejanje, string cbBrSoba)
        {
            driver.FindElement(By.Id("naslovTxt")).SendKeys(Naslov);
            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("tipOpt")));
            oSelectTip.SelectByValue(Combobox1Prvi);
            SelectElement oSelectDrzava = new SelectElement(driver.FindElement(By.Id("gradOpt")));
            oSelectDrzava.SelectByValue("Niš");
            driver.FindElement(By.Id("povrsinaTxt")).SendKeys(m2);
            driver.FindElement(By.Id("cenaTxt")).SendKeys(tbPrice);
            driver.FindElement(By.XPath("//*[@id='tipovi-pretplate']/label[1]/input")).Click();
            driver.FindElement(By.Id("deoMestaTxt")).SendKeys(DeoGrada);
            oSelectTip = new SelectElement(driver.FindElement(By.Id("grejanjeOpt")));

            if (cbGrejanje == "Centralno (CG)") oSelectTip.SelectByText("Centralno");
            else if (cbGrejanje == "Struja") oSelectTip.SelectByText("Električno");
            else if (cbGrejanje == "Gas") oSelectTip.SelectByText("Gas");
            else if (cbGrejanje == "Podno") oSelectTip.SelectByText("Podno");
            else if (cbGrejanje == "Kraljeva Pec") oSelectTip.SelectByText("Čvrsta goriva");
            else { }
            driver.FindElement(By.Id("spratTxt")).SendKeys(Combobox2Sprat);///BUG FIX TODO spratnos kad je kuća
            driver.FindElement(By.Id("sobeTxt")).SendKeys(cbBrSoba);
            driver.FindElement(By.Id("kupatilaTxt")).SendKeys(bathroom);
            driver.FindElement(By.Id("teraseTxt")).SendKeys(terrace);
            driver.FindElement(By.Id("godisteTxt")).SendKeys(year);
            driver.FindElement(By.Id("opis")).SendKeys(desc);
            //driver.FindElement(By.Id("posaljiBtn")).Submit();
        }
    }
}
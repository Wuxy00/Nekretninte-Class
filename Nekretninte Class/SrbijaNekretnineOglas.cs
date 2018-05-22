/*****************************************************************************
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
 * Description : Login on srbija-nekretnine.org
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class SrbijaNekretnineOglas
    {
        public void Procede(IWebDriver driver, string DeoGrada, string adress,string adressNumber, string m2,string Combobox1Prvi,string tbPrice,string desc,string bathroom,string terrace,string year,string Combobox2Sprat)
        {
            driver.FindElement(By.Id("naslovTxt")).SendKeys("Stan " + DeoGrada + " " + adress + " " + m2);
            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("tipOpt")));
            oSelectTip.SelectByValue(Combobox1Prvi);
            SelectElement oSelectDrzava = new SelectElement(driver.FindElement(By.Id("gradOpt")));
            oSelectDrzava.SelectByValue("Niš");
            driver.FindElement(By.Id("povrsinaTxt")).SendKeys(m2);
            driver.FindElement(By.Id("cenaTxt")).SendKeys(tbPrice);
            driver.FindElement(By.XPath("//*[@id='tipovi-pretplate']/label[1]/input")).Click();
            driver.FindElement(By.Id("deoMestaTxt")).SendKeys(DeoGrada);
            driver.FindElement(By.Id("adresaTxt")).SendKeys(adress+" "+ adressNumber);
            driver.FindElement(By.Id("spratTxt")).SendKeys(Combobox2Sprat);
            driver.FindElement(By.Id("kupatilaTxt")).SendKeys(bathroom);
            driver.FindElement(By.Id("teraseTxt")).SendKeys(terrace);
            driver.FindElement(By.Id("godisteTxt")).SendKeys(year);
            driver.FindElement(By.Id("opis")).SendKeys(desc);
            driver.FindElement(By.Id("posaljiBtn")).Submit();
        }
    }
}

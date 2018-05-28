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
        public void Procede(IWebDriver driver,string opstina,string tip,string deoGrada,string grejanje,bool garaza,string godina,string stanje,double cena,string sprat)
        {
            
            driver.Url = "https://crm.indomio.com/sr/dashboard";

            //biraj zemlju
            driver.FindElement(By.CssSelector("#shortcuts > li:nth-child(3) > a")).Click();
            driver.Url = "https://crm.indomio.com/sr/editListing/create";
            driver.FindElement(By.CssSelector("#countryContainer > span > span.select-value")).Click();
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();


            PublicVar.WaitUntilElementExists(driver, By.CssSelector("#regionsContainer > span > span.select-value"), 1);
            //biraj okrug
            driver.FindElement(By.CssSelector("#regionsContainer > span > span.select-value")).Click();
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[14]")).Click();

            //biraj opstinu
            PublicVar.WaitUntilElementExists(driver, By.CssSelector("#munContainer > span > span.select-value"), 1);
            driver.FindElement(By.CssSelector("#munContainer > span > span.select-value")).Click();
            string opst = "niš-" + opstina.ToLower() ;
            bool nastavi = true;
            for(int i = 6; i <= 10 && nastavi; i++)
            {
                PublicVar.WaitUntilElementExists(driver, By.XPath("/html/body/span[3]/span[" + i + "]"), 1);
                var opcija = driver.FindElement(By.XPath("/html/body/span[3]/span["+i+"]"));
                if (opcija.GetAttribute("textContent").ToLower() == opst)
                {
                    opcija.Click();
                    nastavi = false;
                }
            }
            // biraj naselje
            driver.FindElement(By.CssSelector("# hoodContainer > span > span.select-value")).Click();
            nastavi = true;
            int granica = 0;
            switch (opstina)
            {
                case ("Crveni krst"):
                    granica = 37;
                    break;
                case ("Medijana"):
                    granica = 39;
                    break;
                case ("Niška Banja"):
                case ("Pantelej"):
                    granica = 21;
                    break;
                case ("Palilula"):
                    granica = 34;
                    break;
            }
            for (int i = 2; i <= granica && nastavi; i++)
            {
                var opcija = driver.FindElement(By.XPath("/html/body/span[3]/span[" + i + "]"));
                if (opcija.GetAttribute("textContent").ToLower() == deoGrada)
                {
                    opcija.Click();
                    nastavi = false;
                }
            }

            //biraj svrhu
            
            if (tip == "Poslovni prostor")
            {
                driver.FindElement(By.Id("office_category")).Click();
            }
            else if (tip =="Garaza")
            {
                driver.FindElement(By.Id("rest_category")).Click();
            }
            else
            {
                if (tip == "Kuca")
                {
                    driver.FindElement(By.CssSelector("# propertyTypeContainer > span > span.select-value")).Click();
                    driver.FindElement(By.CssSelector("body > span > span.drop - down.custom - scroll > span:nth - child(4)")).Click();

                }
                else driver.FindElement(By.Id("house_category")).Click();
              
            }

            //grejanje
            driver.FindElement(By.CssSelector("body > span > span.select-value")).Click();
            if (grejanje == "Centralno (CG)")
            {
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[3]")).Click();
                
            }
            if (grejanje == "Etazno")
            {
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[2]")).Click();
                
            }
            driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(2) > span > span.select-value")).Click();
            if (grejanje == "TA")
            {
                driver.FindElement(By.XPath("/html/body/span/span[3]/span[7]")).Click();
            }
            if (grejanje == "Struja")
            {
                driver.FindElement(By.XPath("/html/body/span/span[3]/span[5]")).Click();
            }
            if (grejanje == "Gas")
            {
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[3]")).Click();
            }

            // izaberi garazu
            driver.FindElement(By.CssSelector("# sidetab-basic > div:nth-child(15) > p:nth-child(3) > span > span.select-value")).Click();
            if(garaza)
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[2]")).Click();
            else driver.FindElement(By.XPath("/ html / body / span / span[3] / span[3]")).Click();

            // godina izgradnje
            driver.FindElement(By.Id("yearBuilt")).SendKeys(godina);

            // u izgradnji?
            if (stanje == "U izgradnji") driver.FindElement(By.Id("switchUnderConstr")).Click();

            // cena
            driver.FindElement(By.Id("inputSell")).SendKeys(cena.ToString());

            // sprat

            driver.FindElement(By.CssSelector("# sidetab-basic > div:nth-child(14) > p:nth-child(3) > span > span.select-value")).Click();
            if (sprat == "Prizemlje")
            {
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[6]")).Click();
            }
            else if (sprat=="Visoko prizemlje")
            {
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span[5]")).Click();
            }
            else
            {
                int brSprat = int.Parse(sprat);
                driver.FindElement(By.XPath("/ html / body / span / span[3] / span["+(5+brSprat)+"]")).Click();
            }



        }
    }
}

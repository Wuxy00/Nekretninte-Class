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
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class FIndomio
    {
        public void Procede(IWebDriver driver,string opstina,string deoGrada, string tip, string grejanje,bool garaza,string godina,string stanje,string cena,string sprat)
        {

<<<<<<< HEAD

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
=======
            //***************************************************************
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='3000']")));
            //***************************************************************


>>>>>>> e09b1c9d27c52f0e7dfcd901150ddf0862b436ee
            driver.Url = "https://crm.indomio.com/sr/editListing/create";


            //biraj zemlju

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#countryContainer > span > span.select-value")));
            driver.FindElement(By.CssSelector("#countryContainer > span > span.select-value")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();

            //biraj okrug
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#regionsContainer > span > span.select-value")));
            driver.FindElement(By.CssSelector("#regionsContainer > span > span.select-value")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[14]")));
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[14]")).Click();

            //biraj opstinu
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#munContainer > span > span.select-arrow")));
            driver.FindElement(By.CssSelector("#munContainer > span > span.select-arrow")).Click();
            string opst = "niš-" + opstina.ToLower() ;
            bool nastavi = true;
            for(int i = 6; i <= 10 && nastavi; i++)
            {
                string putanja = "body > span > span.drop-down.custom-scroll > span:nth-child("+i+")";
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(putanja)));
                var opcija = driver.FindElement(By.CssSelector(putanja));
                if (opcija.GetAttribute("textContent").ToLower() == opst)
                {
                    opcija.Click();
                    nastavi = false;
                }
            }
            // biraj naselje
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#hoodContainer > span > span.select-value")));
            driver.FindElement(By.CssSelector("#hoodContainer > span > span.select-value")).Click();
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
                
                var opcija = driver.FindElement(By.XPath("/html/body/span/span[3]/span[" + i + "]"));
                if (opcija.GetAttribute("textContent").ToLower() == deoGrada.ToLower())
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", opcija);
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#hoodContainer > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#hoodContainer > span > span.select-value")).Click();
                    opcija.Click();
                    nastavi = false;
                }
            }

            //biraj svrhu
            if (tip == "Plac")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(3) > label")));
                driver.FindElement(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(3) > label")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#propertyTypeContainer > span > span.select-value")));
                driver.FindElement(By.CssSelector("#propertyTypeContainer > span > span.select-value")).Click() ;
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")));
                driver.FindElement(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")).Click(); ;
            }
            else if (tip == "Poslovni prostor")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(2) > label")));
                driver.FindElement(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(2) > label")).Click();
            }
            else if (tip =="Garaza")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(4) > label")));
                driver.FindElement(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(4) > label")).Click();
            }
            else
            {
                if (tip == "Kuća")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#propertyTypeContainer > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#propertyTypeContainer > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(4)")));
                    driver.FindElement(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(4)")).Click();

                }
              
            }

            //grejanje
            if (tip != "Plac")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(1) > span > span.select-arrow")));
                driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(1) > span > span.select-arrow")).Click();
                if (grejanje == "Centralno (CG)")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[3]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[3]")).Click();

                }
                else if (grejanje == "Etazno")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/ span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/ span[2]")).Click();

                }
                else
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(2) > span > span.select-arrow")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(2) > span > span.select-value")).Click();
                    if (grejanje == "TA")
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[7]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[7]")).Click();
                    }
                    if (grejanje == "Struja")
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[5]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[5]")).Click();
                    }
                    if (grejanje == "Gas")
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[3]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[3]")).Click();
                    }
                }
            }
            
            // izaberi garazu
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(3) > span > span.select-value")));
            driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(3) > span > span.select-value")).Click();
            if (garaza)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
            }
            else
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[3]")));
                driver.FindElement(By.XPath("/html/body/span/span[3]/span[3]")).Click();
            }

            // godina izgradnje
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("yearBuilt")));
            driver.FindElement(By.Id("yearBuilt")).SendKeys(godina);

            // u izgradnji?
            if (stanje == "U izgradnji")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("switchUnderConstr")));
                driver.FindElement(By.Id("switchUnderConstr")).Click();
            }

            // cena
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputSell")));
            driver.FindElement(By.Id("inputSell")).SendKeys(cena);

            // sprat
            if (tip != "Plac")
            {
                driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(14) > p:nth-child(3) > span > span.select-value")).Click();
                if (sprat == "Prizemlje")
                {
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[6]")).Click();
                }
                else if (sprat == "Visoko prizemlje")
                {
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[5]")).Click();
                }
                else
                {
                    int brSprat = int.Parse(sprat);
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[" + (5 + brSprat) + "]")).Click();
                }
            }



        }
    }
}

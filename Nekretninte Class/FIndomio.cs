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
        public void Procede(IWebDriver driver, string opstina, string deoGrada, string tip, string grejanje, bool garaza, string godina, string stanje, string cena, string sprat, string povrsina, bool izdavanje, string opis, string brKupatila, string brToaleta, string brojLiftova, string Uknjizen, string PodGrupa,string brojSoba,bool dupleks,bool ostava)
        {
            

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Url = "https://crm.indomio.com/sr/editListing/create";
            //prodaja/izdavanje?

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#editListingMainContainer > ul > div.margin-top-60.margin-left > div:nth-child(1) > span")));
            driver.FindElement(By.CssSelector("#editListingMainContainer > ul > div.margin-top-60.margin-left > div:nth-child(1) > span")).Click();
            if (izdavanje)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#listingTypeCheckBoxes > div:nth-child(1) > span > span")));
                driver.FindElement(By.CssSelector("#listingTypeCheckBoxes > div:nth-child(1) > span > span")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#listingTypeCheckBoxes > div.small-margin-top > span")));
                driver.FindElement(By.CssSelector("#listingTypeCheckBoxes > div.small-margin-top > span")).Click();

            }
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
            string opst = "niš-" + opstina.ToLower();
            bool nastavi = true;
            for (int i = 6; i <= 10 && nastavi; i++)
            {
                string putanja = "body > span > span.drop-down.custom-scroll > span:nth-child(" + i + ")";
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
                driver.FindElement(By.CssSelector("#propertyTypeContainer > span > span.select-value")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")));
                driver.FindElement(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")).Click(); ;
            }
            else if (tip == "Poslovni prostor")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(2) > label")));
                driver.FindElement(By.CssSelector("#editListingCategory > div > div.ten-columns.nine-columns-tablet.twelve-columns-mobile > div > span:nth-child(2) > label")).Click();
            }
            else if (tip == "Garaza")
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
                else if (brojSoba == "Garsonjera")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#propertyTypeContainer > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#propertyTypeContainer > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")));
                    driver.FindElement(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(2)")).Click();
                }
                else if (dupleks)
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#propertyTypeContainer > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#propertyTypeContainer > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(3)")));
                    driver.FindElement(By.CssSelector("body > span > span.drop-down.custom-scroll > span:nth-child(3)")).Click();
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
                    if (grejanje == "Podno")
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(35) > span > span.select-value")));
                        driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(35) > span > span.select-value")).Click();
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                    }
                }
            }

            // izaberi garazu
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(3) > span > span.select-arrow")));
            driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(15) > p:nth-child(3) > span > span.select-arrow")).Click();
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
            if (izdavanje)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputRent")));
                driver.FindElement(By.Id("inputRent")).SendKeys(cena);
            }
            else
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputSell")));
                driver.FindElement(By.Id("inputSell")).SendKeys(cena);
            }

            // sprat
            if (tip != "Plac")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div:nth-child(14) > p:nth-child(3) > span > span.select-value")));
                driver.FindElement(By.CssSelector("#sidetab-basic > div:nth-child(14) > p:nth-child(3) > span > span.select-value")).Click();
                if (sprat == "Prizemlje")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[6]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[6]")).Click();
                }
                else if (sprat == "Visoko Prizemlje")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[5]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[5]")).Click();
                }
                else
                {
                    int brSprat = int.Parse(sprat);
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[" + (5 + brSprat) + "]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[" + (5 + brSprat) + "]")).Click();
                }
            }

            // povrsina
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#inputArea")));
            driver.FindElement(By.CssSelector("#inputArea")).SendKeys(povrsina);

            //opis 
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#descriptionGr")));
            driver.FindElement(By.CssSelector("#descriptionGr")).SendKeys(opis);

            if (tip != "Plac")
            {
                //broj wc
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#inputWC")));
                driver.FindElement(By.CssSelector("#inputWC")).SendKeys(brToaleta);

                //broj Kupatila 
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#inputBathrooms")));
                driver.FindElement(By.CssSelector("#inputBathrooms")).SendKeys(brKupatila);

                // Lift?
                if (int.Parse(brojLiftova) > 0)
                {
                   
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(6) > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(6) > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                // da li je penthouse?
                if (tip!="Garaza")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(20) > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(20) > span > span.select-value")).Click();
                    if (PodGrupa == "Penthaus")
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                    }
                    else
                    {
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[3]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[3]")).Click();
                    }
                }
                
                if(stanje=="Novo")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(8) > span > span.select-arrow")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(8) > span > span.select-arrow")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                if (stanje == "U izgradnji")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(32) > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(32) > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                if (tip!="Garaza" && stanje == "Renovirano")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(18) > span > span.select-value")));
                    driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(18) > span > span.select-value")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
            }
            else
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(25) > span > span.select-value")));
                driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(25) > span > span.select-value")).Click();
                if (Uknjizen == "Jeste" || Uknjizen=="Delimicno")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                else
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
            }

            if (ostava)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(7) > span > span.select-value")));
                driver.FindElement(By.CssSelector("#sidetab-basic > div.seven-columns.twelve-columns-mobile > p:nth-child(7) > span > span.select-value")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                
            }
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#submitButton > button > span")));
            PublicVar.ScrollUntilVisible(driver, driver.FindElement(By.CssSelector("#submitButton > button > span")), false);
            driver.FindElement(By.CssSelector("#submitButton > button > span")).Click();
        }
    }
}

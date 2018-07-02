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
        public void Procede(IWebDriver driver, string opstina, string deoGrada, string tip, string grejanje, bool garaza, string godina, string stanje, string cena, string sprat, string povrsina, bool izdavanje, string opis, string brKupatila, string brToaleta, string brojLiftova, string Uknjizen, string PodGrupa, string brojSoba, bool dupleks, bool ostava)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Url = "https://crm.indomio.com/sr/editListing/create";


            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='editListingMainContainer']/ul/div[1]/div[1]/span")));
            driver.FindElement(By.XPath("//*[@id='editListingMainContainer']/ul/div[1]/div[1]/span")).Click();

            //prodaja/izdavanje?
            if (izdavanje)
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='listingTypeCheckBoxes']/div[1]/span/span")));
                driver.FindElement(By.XPath("//*[@id='listingTypeCheckBoxes']/div[1]/span/span")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='listingTypeCheckBoxes']/div[2]/span")));
                driver.FindElement(By.XPath("//*[@id='listingTypeCheckBoxes']/div[2]/span")).Click();
            }

            //biraj zemlju
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='countryContainer']/span/span[1]")));
            driver.FindElement(By.XPath("//*[@id='countryContainer']/span/span[1]")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();

            //biraj okrug
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='regionsContainer']/span/span[1]")));
            driver.FindElement(By.XPath("//*[@id='regionsContainer']/span/span[1]")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[14]")));
            driver.FindElement(By.XPath("/html/body/span/span[3]/span[14]")).Click();

            //biraj opstinu
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='munContainer']/span/span[1]")));
            driver.FindElement(By.XPath("//*[@id='munContainer']/span/span[1]")).Click();
            string opst = "niš-" + opstina.ToLower();
            bool nastavi = true;
            for (int i = 6; i <= 10 && nastavi; i++)
            {
                string putanja = "/html/body/span/span[3]/span[" + i + "]";
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(putanja)));
                var opcija = driver.FindElement(By.XPath(putanja));
                if (opcija.GetAttribute("textContent").ToLower() == opst)
                {
                    opcija.Click();
                    nastavi = false;
                }
            }
            // biraj naselje
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='hoodContainer']/span/span[1]")));
            driver.FindElement(By.XPath("//*[@id='hoodContainer']/span/span[1]")).Click();
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
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='hoodContainer']/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='hoodContainer']/span/span[1]")).Click();
                    opcija.Click();
                    nastavi = false;
                }
            }

            //biraj svrhu
            if (tip == "Plac")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[3]/span")));
                driver.FindElement(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[3]/span")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")));
                driver.FindElement(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")).Click();
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("body > span > span.drop-down.custom-scroll > span:nth-child(2)")));
                driver.FindElement(By.XPath("body > span > span.drop-down.custom-scroll > span:nth-child(2)")).Click(); ;
            }
            else if (tip == "Poslovni prostor")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[2]/span")));
                driver.FindElement(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[2]/span")).Click();
            }
            else if (tip == "Garaza")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[4]/span")));
                driver.FindElement(By.XPath("//*[@id='editListingCategory']/div/div[2]/div/span[4]/span")).Click();
            }
            else
            {

                if (tip == "Kuća")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[4]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[4]")).Click();
                }
                else if (brojSoba == "Garsonjera")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                else if (dupleks)
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='propertyTypeContainer']/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[3]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[3]")).Click();
                }

            }

            //grejanje
            if (tip != "Plac")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[13]/p[1]/span/span[1]")));
                driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[13]/p[1]/span/span[1]")).Click();
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
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[13]/p[2]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[13]/p[2]/span/span[1]")).Click();
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
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[35]/span/span[1]")));
                        driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[35]/span/span[1]")).Click();
                        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                        driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                    }
                }
            }

            // izaberi garazu
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[13]/p[3]/span/span[1]")));
            driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[13]/p[3]/span/span[1]")).Click();
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

            // u izgradnji?
            if (stanje == "U izgradnji")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[13]/p[5]/span/span[2]")));
                driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[13]/p[5]/span/span[2]")).Click();
            }
            else
            {
                // godina izgradnje
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("yearBuilt")));
                driver.FindElement(By.Id("yearBuilt")).SendKeys(godina);
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
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[12]/p[3]/span/span[1]")));
                driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[12]/p[3]/span/span[1]")).Click();
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
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputArea")));
            driver.FindElement(By.Id("inputArea")).SendKeys(povrsina);

            //opis 
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("descriptionGr")));
            driver.FindElement(By.Id("descriptionGr")).SendKeys(opis);

            if (tip != "Plac")
            {
                //broj wc
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputWC")));
                driver.FindElement(By.Id("inputWC")).SendKeys(brToaleta);

                //broj Kupatila 
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("inputBathrooms")));
                driver.FindElement(By.Id("inputBathrooms")).SendKeys(brKupatila);

                // Lift?
                if (int.Parse(brojLiftova) > 0)
                {

                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[6]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[6]/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                // da li je penthouse?
                if (tip != "Garaza")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[20]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[20]/span/span[1]")).Click();
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

                if (stanje == "Novo")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[8]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[8]/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }
                if (tip != "Garaza" && stanje == "Renovirano")
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[16]/p[18]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[16]/p[18]/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();
                }

                if (ostava)
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[7]/span/span[1]")));
                    driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[7]/span/span[1]")).Click();
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/span/span[3]/span[2]")));
                    driver.FindElement(By.XPath("/html/body/span/span[3]/span[2]")).Click();

                }
            }
            else
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='sidetab-basic']/div[17]/p[25]/span/span[1]")));
                driver.FindElement(By.XPath("//*[@id='sidetab-basic']/div[17]/p[25]/span/span[1]")).Click();
                if (Uknjizen == "Jeste" || Uknjizen == "Delimicno")
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


            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='submitButton']/button")));
            PublicVar.ScrollUntilVisible(driver, driver.FindElement(By.XPath("//*[@id='submitButton']/button")), false);
            driver.FindElement(By.XPath("//*[@id='submitButton']/button")).Click();
        }
    }
}

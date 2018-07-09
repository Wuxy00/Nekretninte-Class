/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : NadjiDom.cs
 *
 * Created By  : Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill Halo Oglasi
 *               
 *
 *****************************************************************************/
//TOODOO:
//  1)Photo upload
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace Nekretninte_Class
{
    class FHaloOglasi
    {
        public void Proceed(IWebDriver driver, string tip, bool prodaja, string tipObjekta, string naslov, string cena, string kvadratura, string brojSoba
            , string stanjeObjekta, string grejanje, string sprat, bool uknjizen, bool dupleks, bool lift, bool terasa, bool podrum, bool garaza, bool lodja, bool interfon,
            bool parking, bool telefon, string dodatanOpis, string opstina, int okrugInd, string dodatanTip)
        {
            driver.Url = "https://www.halooglasi.com/postavite-oglas";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            driver.FindElement(By.XPath("//*[@id='1']/a")).Click();
            if (tip == "Poslovni")
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='4']/a")));
                driver.FindElement(By.XPath("//*[@id='4']/a")).Click();
                if (prodaja)
                {
                    driver.FindElement(By.XPath("//*[@id='2003']/a")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath("//*[@id='2004']/a")).Click();
                }
            }
            else
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='2']/a")));
                driver.FindElement(By.XPath("//*[@id='2']/a")).Click();
                if (prodaja)
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='2001']/a")));
                    driver.FindElement(By.XPath("//*[@id='2001']/a")).Click();
                    switch (tipObjekta)
                    {
                        case "Stan":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='12']/a")));
                            driver.FindElement(By.XPath("//*[@id='12']/a")).Click(); break;
                        case "Kuća":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='24']/a")));
                            driver.FindElement(By.XPath("//*[@id='24']/a")).Click(); break;
                        case "Garaza":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='28']/a")));
                            driver.FindElement(By.XPath("//*[@id='28']/a")).Click(); break;
                        case "Plac":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='26']/a")));
                            driver.FindElement(By.XPath("//*[@id='26']/a")).Click(); break;
                    }
                }
                else
                {
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='2002']/a")));
                    driver.FindElement(By.XPath("//*[@id='2002']/a")).Click();
                    switch (tipObjekta)
                    {
                        case "Stan":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='13']/a")));
                            driver.FindElement(By.XPath("//*[@id='13']/a")).Click(); break;
                        case "Kuća":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='25']/a")));
                            driver.FindElement(By.XPath("//*[@id='25']/a")).Click(); break;
                        case "Garaza":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='29']/a")));
                            driver.FindElement(By.XPath("//*[@id='29']/a")).Click(); break;
                        case "Plac":
                            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='27']/a")));
                            driver.FindElement(By.XPath("//*[@id='27']/a")).Click(); break;
                    }
                }
            }
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='next']")));
            //PublicVar.ScrollUntilVisible(driver, driver.FindElement(By.XPath("//*[@id='next']")), true);
            driver.FindElement(By.XPath("//*[@id='next']")).Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[3]/div/div/input")));

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[3]/div/div/input")).SendKeys(naslov);

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[4]/div/div/div[2]/input")).SendKeys(cena);
            
            SelectLocation(driver, opstina, okrugInd);           

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[1]/ul/li[2]/span/div/input")).SendKeys(kvadratura);

            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[1]/ul/li[3]/span/div/select")));
            if (brojSoba == "Garsonjera") select.SelectByValue("398");
            else
            {
                if (!brojSoba.Contains(".")) brojSoba += ".0";
                select.SelectByText(brojSoba);  
            }

            select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/select")));
            select.SelectByValue("387238");

            select = new SelectElement(driver.FindElement(By.Name("tip_objekta")));
            switch (stanjeObjekta)
            {
                case "Novo":
                    select.SelectByText("Novogradnja");
                    select = new SelectElement(driver.FindElement(By.Name("stanje_objekta")));
                    select.SelectByText("Izvorno stanje"); break;
                case "U izgradnji":
                    select.SelectByText("U izgradnji");
                    select = new SelectElement(driver.FindElement(By.Name("stanje_objekta")));
                    select.SelectByText("Izvorno stanje"); break;
                case "Renovirano":
                    select = new SelectElement(driver.FindElement(By.Name("stanje_objekta")));
                    select.SelectByText("Renovirano"); break;
                case "Potrebno renoviranje":
                    select = new SelectElement(driver.FindElement(By.Name("stanje_objekta")));
                    select.SelectByText("Za renoviranje"); break;
                default:

                    select.SelectByText("Stara gradnja"); break;
            }
            select = new SelectElement(driver.FindElement(By.Name("grejanje")));
            switch (grejanje)
            {
                case "Centralno (CG)":
                case "Struja":
                    select.SelectByText("CG"); break;
                case "Etazno":
                    select.SelectByText("EG"); break;
                default:
                    select.SelectByText(grejanje); break;
            }
            select = new SelectElement(driver.FindElement(By.Name("sprat")));
            switch (sprat)
            {
                case "Suturen (Nisko P  rizelmlje)":
                    select.SelectByText("SUT"); break;
                case "prizelmlje":
                    select.SelectByText("SUT"); break;
            }

            if (uknjizen) driver.FindElement(By.Id("12000004")).Click();
            if (dupleks) driver.FindElement(By.Id("12000013")).Click();
            if (terasa) driver.FindElement(By.Id("12100001")).Click();
            if (lift) driver.FindElement(By.Id("12100007")).Click();
            if (podrum) driver.FindElement(By.Id("12100008")).Click();
            if (garaza) driver.FindElement(By.Id("12100016")).Click();
            if (lodja) driver.FindElement(By.Id("12100019")).Click();
            if (interfon) driver.FindElement(By.Id("12100013")).Click();
            if (parking) driver.FindElement(By.Id("12100017")).Click();
            if (telefon) driver.FindElement(By.Id("12100010")).Click();
            switch (dodatanTip)
            {
                case "Salonac":
                    driver.FindElement(By.Id("12000012")).Click(); break;
                case "Penthaus":
                    driver.FindElement(By.Id("12000014")).Click(); break;
            }

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[3]/ul/li/div[1]/div[1]/div/div[6]/div/div[2]")).SendKeys(dodatanOpis);

        }
        public void UploadPhotos(IWebDriver driver, string[] photos)
        {
            PublicVar.UploadPhotos(driver, By.Name("Images_files"), photos);
        }
        private void SelectLocation(IWebDriver driver,string opstina, int okrugInd)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //Actions actions = new Actions(driver);
            //IWebElement nesto = driver.FindElement(By.) 
            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[1]/div/input[2]")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[1]/div/div[2]/div[1]/ul/li[3]")));
            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[1]/div/div[2]/div[1]/ul/li[3]")).Click();
            
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[1]")));
            switch (opstina)
            {
                case "Crveni krst":
                    driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[1]")).Click(); break;
                case "Medijana":
                    driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[2]")).Click(); break;
                case "Niška Banja":
                    driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[3]")).Click(); break;
                case "Palilula":
                    driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[4]")).Click(); break;
                case "Pantelej":
                    driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/ul/li[5]")).Click(); break;
            }            
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[3]/div/div[2]/div[1]/ul/li[1]")));
            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[6]/div[2]/div[1]/div/div/div[3]/div/div[2]/div[1]/ul/li[" + (okrugInd + 1).ToString() + "]")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='mapDisplay']/iframe")));
            driver.FindElement(By.XPath("//*[@id='mapDisplay']/iframe")).Click();
        }
    }
}

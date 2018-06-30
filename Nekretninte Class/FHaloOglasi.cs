using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Nekretninte_Class
{
    class FHaloOglasi
    {
        public void Proceed(IWebDriver driver, string tip, bool prodaja, string tipObjekta, string naslov, string cena, string kvadratura, string brojSoba
            ,string stanjeObjekta)
        {
            driver.Url = "https://www.halooglasi.com/postavite-oglas";

            driver.FindElement(By.XPath("//*[@id='1']/a")).Click();
            if (tip == "Poslovni")
            {
                driver.FindElement(By.XPath("//*[@id='4']/a")).Click();
                if (prodaja)
                {
                    driver.FindElement(By.XPath("//*[@id='2001']/a")).Click();
                    switch (tipObjekta)
                    {
                        case "Stan":
                            driver.FindElement(By.XPath("//*[@id='12']/a")).Click(); break;
                        case "Kuća":
                            driver.FindElement(By.XPath("//*[@id='24']/a")).Click(); break;
                        case "Garaza":
                            driver.FindElement(By.XPath("//*[@id='28']/a")).Click(); break;
                        case "Plac":
                            driver.FindElement(By.XPath("//*[@id='26']/a")).Click(); break;
                    }
                }
                else
                {
                    driver.FindElement(By.XPath("//*[@id='2002']/a")).Click();
                    switch (tipObjekta)
                    {
                        case "Stan":
                            driver.FindElement(By.XPath("//*[@id='13']/a")).Click(); break;
                        case "Kuća":
                            driver.FindElement(By.XPath("//*[@id='25']/a")).Click(); break;
                        case "Garaza":
                            driver.FindElement(By.XPath("//*[@id='29']/a")).Click(); break;
                        case "Plac":
                            driver.FindElement(By.XPath("//*[@id='27']/a")).Click(); break;
                    }
                }
            }
            else
            {
                driver.FindElement(By.XPath("//*[@id='2']/a")).Click();
                if (prodaja)
                {
                    driver.FindElement(By.XPath("//*[@id='2003']/a")).Click();                    
                }
                else
                {
                    driver.FindElement(By.XPath("//*[@id='2004']/a")).Click();
                }
            }
            driver.FindElement(By.XPath("//*[@id='next']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[3]/div/div/input")));

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[3]/div/div/input")).SendKeys(naslov);
            
            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[1]/div/div[4]/div/div/div[2]/input")).SendKeys(cena);

            //TOODOO LOKACIJA
            //*
            //*
            //*
            //TOODOO LOKACIJA

            driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[1]/ul/li[2]/span/div/input")).SendKeys(kvadratura);

            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[1]/ul/li[3]/span/div/select")));
            if (brojSoba == "Garsonjera") select.SelectByValue("398");            
            else
            {
                int pocetniIndex = 399;
                double broj = Convert.ToDouble(brojSoba) * 2;
                select.SelectByValue((pocetniIndex + broj).ToString());
            }

            select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/select")));
            select.SelectByValue("387238");
            
            select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[2]/div[2]/div/select")));            
            switch (stanjeObjekta)
            {
                case "Novo":
                    select.SelectByText("Novogradnja");
                    select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[3]/div[2]/div/select")));
                    select.SelectByText("Izvorno stanje");  break;
                case "U izgradnji":
                    select.SelectByText("U izgradnji");
                    select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[3]/div[2]/div/select")));
                    select.SelectByText("Izvorno stanje"); break;
                case "Renovirano":                   
                    select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[3]/div[2]/div/select")));
                    select.SelectByText("Renovirano"); break;
                case "Potrebno renoviranje":
                    select = new SelectElement(driver.FindElement(By.XPath("//*[@id='tab2']/div[1]/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[3]/div/div/div/div[3]/div[2]/div/select")));
                    select.SelectByText("Za renoviranje"); break;
                default:
                    select.SelectByText("Starogradnja"); break;
            }
        }
    }
}

/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FNekretnineRs.cs
 *
 * Created By  : Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill nekretnine.rs
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class FNekretnineRs
    {
        public void Setup(IWebDriver driver)
        {
            driver.Url = "https://www.nekretnine.rs/member/Insertion/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='instructionWrapper']/div[2]/a")));
            driver.FindElement(By.XPath("//*[@id='instructionWrapper']/div[2]/a")).Click();
        }
        public void Proceed(IWebDriver driver, bool izdavanje, string sTipObjekta, string sRegija, string sNaslov, string sOpis, string sCena, string sKvadratura, string sUknjizeno, string sBrSoba, string sBrKupatila, string sSprat, string cInterfon, string cTelefon)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='3000']")));

            if (izdavanje) driver.FindElement(By.XPath("//*[@id='3000']")).Click();
            SelectElement selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='mainCategory']"))); //NE TESTIRANOOOOO!!!
            switch (sTipObjekta)
            {
                case "Stan": selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Stanovi"); break;
                case "Kuća": selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Kuće"); break;
                case "Garaza": selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Pomoćni objekti"); break;
                case "Plac": selection.SelectByText("Stambeni objekti"); break;
                default: selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Lokali i skladista"); break;
            }

            driver.FindElement(By.XPath("//*[@id='city']")).SendKeys("Niš");            
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//a[contains(text(),'18000 Niš')]")));
            driver.FindElement(By.XPath("//a[contains(text(),'18000 Niš')]")).Click();

            //selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='cityArea']")));
            //selection.SelectByText(sRegija);

            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[1]/div[2]/input")).SendKeys(sNaslov);
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[2]/div[2]/textarea")).SendKeys(sOpis);
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[1]/div[2]/input")).SendKeys(sCena);
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[2]/div[2]/input")).SendKeys(sKvadratura);

            if(sUknjizeno == "Jeste") driver.FindElement(By.XPath("//*[@id='1009']")).Click();

            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[6]/div[2]/input")).SendKeys(sBrSoba);
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[7]/div[2]/input")).SendKeys(sBrKupatila);
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[8]/div[2]/input")).SendKeys(sSprat);
            if(cInterfon!=null) driver.FindElement(By.XPath("//*[@id='3006']")).Click();
            if(cTelefon!=null) driver.FindElement(By.XPath("//*[@id='1009']")).Click();
        }              
    }
}

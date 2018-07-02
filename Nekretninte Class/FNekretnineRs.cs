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
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='instructionWrapper']/div[2]/a")));
            //driver.FindElement(By.XPath("//*[@id='instructionWrapper']/div[2]/a")).Click();
        }
        public void Proceed(IWebDriver driver, bool izdavanje, string sTipObjekta, string sRegija, string sNaslov, string sOpis,
            string sCena, string sKvadratura, string sUknjizeno, string sBrSoba, string sBrKupatila, string sSprat, string cInterfon,
            string cTelefon, string godIzgradnje, string terasa, string basta, string parking, string garaza, string lodja, bool ostava,
            bool podrum, string lift, string grejanje, bool dupleks, string stanje)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='3000']")));

            if (izdavanje) driver.FindElement(By.XPath("//*[@id='3000']")).Click();
            IWebElement cookieCloser = null;
            try
            {
                cookieCloser = driver.FindElement(By.XPath("//*[@id='billboardgyxnlhsmlflqvspmseioqfrt']/div/div[2]"));
            }
            catch { }
            if (cookieCloser != null) cookieCloser.Click();
            SelectElement selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='mainCategory']")));
            switch (sTipObjekta)
            {
                case "Stan":
                    selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Stanovi"); break;
                case "Kuća":
                    selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Kuće"); break;
                case "Garaza":
                    selection.SelectByText("Stambeni objekti");
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='subCategory']")));
                    selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='subCategory']")));
                    selection.SelectByText("Pomoćni objekti"); break;
                case "Plac": selection.SelectByText("Stambeni objekti"); break;
                default:
                    selection.SelectByText("Stambeni objekti");
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

            if (sUknjizeno == "Jeste") driver.FindElement(By.XPath("//*[@id='1009']")).Click();
            if (dupleks) driver.FindElement(By.XPath("//*[@id='3023']")).Click();
            selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[5]/div[2]/select")));
            switch (stanje)
            {
                case "Uobičajeno": selection.SelectByIndex(1); break;
                case "Novo": selection.SelectByIndex(2); break;
                case "U izgradnji": selection.SelectByIndex(3); break;
            }
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[6]/div[2]/input")).SendKeys(sBrSoba); //broj soba
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[7]/div[2]/input")).SendKeys(sBrKupatila); //broj kupatila
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[8]/div[2]/input")).SendKeys(sSprat); //sprat
            if (cInterfon != null) driver.FindElement(By.XPath("//*[@id='3006']")).Click();
            if (cTelefon != null) driver.FindElement(By.XPath("//*[@id='3007']")).Click();
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[11]/div[2]/input")).SendKeys(godIzgradnje); //godina izgradnje
            if (terasa != null) driver.FindElement(By.XPath("//*[@id='3026']")).Click();
            if (basta != null) driver.FindElement(By.XPath("//*[@id='3027']")).Click();
            if (parking != null) driver.FindElement(By.XPath("//*[@id='3028']")).Click();
            if (garaza != null) driver.FindElement(By.XPath("//*[@id='3029']")).Click();
            if (lodja != null) driver.FindElement(By.XPath("//*[@id='3031']")).Click();
            if (ostava) driver.FindElement(By.XPath("//*[@id='12674']")).Click();
            if (podrum) driver.FindElement(By.XPath("//*[@id='12701']")).Click();
            if (lift != null) driver.FindElement(By.XPath("//*[@id='3033']")).Click();
            selection = new SelectElement(driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[3]/div[3]/div[14]/div[2]/select")));
            switch (grejanje)
            {
                case "Centralno (CG)": selection.SelectByText("Centralno grejanje"); break;
                case "Etazno": selection.SelectByText("Etažno grejanje / grejno telo"); break;
                default: selection.SelectByText("Daljinsko grejanje"); break;
            }
            driver.FindElement(By.XPath("//*[@id='advertTerms']/div/div[2]/input")).Click();
        }
        public void UploadPhotos(IWebDriver driver, string[] photos)
        {
            driver.FindElement(By.XPath("//*[@id='advertInfoForm']/div[5]/a[2]")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='ui-tabs-2']")));
            PublicVar.UploadPhotos(driver, 57, photos);
        }
    }
}

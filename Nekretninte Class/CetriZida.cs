/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : AllTextInputForms.cs
 *
 * Created By  : Vukašin Stamenković & Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill text input places
 *               
 *
 *****************************************************************************/
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Nekretninte_Class
{
    class CetriZida
    {
        public void Proceed(IWebDriver driver, string price, string m2, string DeoGrada, string year, string loggia, string terrace, string phone,
            string intercom, string elevator, string bathroom, string toilet, string parkingSpace, string garage, string desc, bool prodaja) // Price and M2 fill
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            if (prodaja) driver.Url = "https://www.4zida.rs/novi-oglas/prodaja";
            else driver.Url = "https://www.4zida.rs/novi-oglas/izdavanje";
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("price")));
            driver.FindElement(By.Id("price")).SendKeys(price);
            driver.FindElement(By.Id("m2")).SendKeys(m2);
            driver.FindElement(By.Id("placeId")).SendKeys(DeoGrada);
            driver.FindElement(By.Id("year")).SendKeys(year);
            driver.FindElement(By.Id("loggia")).SendKeys(loggia);
            driver.FindElement(By.Id("terrace")).SendKeys(terrace);
            driver.FindElement(By.Id("phone")).SendKeys(phone);
            driver.FindElement(By.Id("intercom")).SendKeys(intercom);
            driver.FindElement(By.Id("elevator")).SendKeys(elevator);
            driver.FindElement(By.Id("bathroom")).SendKeys(bathroom);
            driver.FindElement(By.Id("toilet")).SendKeys(toilet);
            driver.FindElement(By.Id("parkingSpace")).SendKeys(parkingSpace);
            driver.FindElement(By.Id("garage")).SendKeys(garage);
            driver.FindElement(By.Id("desc")).SendKeys(desc);
        }
        public void ProceedMultipleChoice(IWebDriver driver, int indexGroup, int indexPurpous, int indexStructure, int indexUknjizeno, int indexState, int indexSprat, int indexGrejanje)
        {
            Select(driver, indexGroup, "architecture", "state");
            Select(driver, indexPurpous, "generalPurpose", "generalPurpose");
            Select(driver, indexStructure, "structure", "structure");
            Select(driver, indexUknjizeno, "architecture", "state", "//*[@id='details']/div[14]/div/div[2]/div");
            Select(driver, indexState, "state", "state", "//*[@id='details']/div[20]/div[1]/div[2]/div");
            Select(driver, indexSprat, "floor", "floor");
            Select(driver, indexGrejanje, "heatingType", "heatingType");
        }
        private void Select(IWebDriver driver, int index, string aria, string buttonName)
        {
            driver.FindElement(By.Id(buttonName)).Click();
            IWebElement meni = driver.FindElement(By.XPath("//ul[@aria-labelledby='" + aria + "']"));
            meni.FindElements(By.TagName("a"))[index + 1].Click();
        }
        private void Select(IWebDriver driver, int index, string aria, string buttonName, string xPath) //Zbog slepca samoukog koji nikad kompjuter nije uvatio u ruke
        {
            IWebElement div = driver.FindElement(By.XPath(xPath));
            div.FindElement(By.Id(buttonName)).Click();
            IWebElement meni = div.FindElement(By.TagName("ul"));
            meni.FindElements(By.TagName("a"))[index + 1].Click();
        }
        private void LocationBypass()
        {
            //int brojKlika = 0;
            //switch (DeoGrada)
            //{
            //    case "Pantelej": brojKlika = 4; break;
            //    case "Medijana": brojKlika = 1; break;
            //    case "Niška Banja": brojKlika = 2; break;
            //    case "Palilula": brojKlika = 3; break;
            //    case "Crveni krst": brojKlika = 5; break;
            //    default: brojKlika = 0; break;
            //}            
            //driver.FindElement(By.XPath("//*[@id='placeId']")).SendKeys("Nis");
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='location - view']/div/div[1]/div[2]")));
            //Actions actions = new Actions(driver);
            //for (int i = 0; i < brojKlika; ++i)
            //{
            //    actions.SendKeys(Keys.ArrowDown);
            //}
            //actions.SendKeys(Keys.Enter);
        }
    }
}

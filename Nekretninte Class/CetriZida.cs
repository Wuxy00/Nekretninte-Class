﻿/*****************************************************************************
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
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class CetriZida
    {
        public void Proceed(IWebDriver driver, string price, string m2, string DeoGrada,string adress,string addressNumber,string year,string loggia, string terrace, string phone, string intercom, string elevator,string bathroom, string toilet, string parkingSpace, string garage, string busLine,string trolleyCarLine,string trolleybusLine, string desc) // Price and M2 fill
        {
            driver.FindElement(By.Id("price")).SendKeys(price);
            driver.FindElement(By.Id("m2")).SendKeys(m2);
            driver.FindElement(By.Id("placeId")).SendKeys(DeoGrada);
            driver.FindElement(By.Id("address")).SendKeys(adress);
            driver.FindElement(By.Id("address-number")).SendKeys(addressNumber);
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
            driver.FindElement(By.Id("busLine")).SendKeys(busLine);
            driver.FindElement(By.Id("trolleyCarLine")).SendKeys(trolleyCarLine);
            driver.FindElement(By.Id("trolleybusLine")).SendKeys(trolleybusLine);
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
            IWebElement meni = div.FindElement(By .TagName("ul"));
            meni.FindElements(By.TagName("a"))[index + 1].Click();
        }
    }
}

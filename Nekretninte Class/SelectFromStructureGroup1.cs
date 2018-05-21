/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : SelectFromStructureGroup1.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Chose element from first block of radio buttons on page: "www.4zida.rs/novi-oglas/prodaja"
 *               
 *
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class SelectFromStructureGroup1
    {
        string url = "https://www.4zida.rs/novi-oglas/prodaja";

        public void Setup(IWebDriver driver) => driver.Url = url; // Go on new URL

        public void Procced(IWebDriver driver, string ComparingData) // Radio button find and  click
        {
            if (ComparingData == "Stan")
                ComparingData = "appartment";
            else if (ComparingData == "Kuca")
                ComparingData = "house";
            else if (ComparingData == "Poslovni prostor")
                ComparingData = "office_btn";
            else if (ComparingData == "Plac")
                ComparingData = "lot";
            else
                ComparingData = "vehicle-spot";

            IList<IWebElement> RadioBox = driver.FindElements(By.Name("structure"));
            int Size = RadioBox.Count;
            for (int i = 0; i < Size; i++)
            {
                string Value = RadioBox.ElementAt(i).GetAttribute("id");

                if (Value.Equals(ComparingData))
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    RadioBox[i].Click();
                }
            }
        }
    }
}
        

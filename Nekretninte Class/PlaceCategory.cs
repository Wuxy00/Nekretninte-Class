/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : PlaceCategory.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill The Form, first dropdown menu
 *               
 *
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class PlaceCategory
    {
        public void Procced(IWebDriver driver, string ComparingData) // Place description
        {
            if (ComparingData == "Stan")
                ComparingData = "Stan";
            else if (ComparingData == "Apartman")
                ComparingData = "Apartman";
            else if (ComparingData == "Salonac")
                ComparingData = "Salonac";
            else if (ComparingData == "Penthaus")
                ComparingData = "Penthaus";
            else
                ComparingData = "Dvorišni stan";
            SelectElement dropdown = new SelectElement(driver.FindElement(By.ClassName("dropdown-menu")));
            dropdown.SelectByValue(ComparingData);
        }
    }
}

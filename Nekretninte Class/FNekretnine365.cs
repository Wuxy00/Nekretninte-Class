/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FNekretnine365.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill Nekretnine365.com
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
    class FNekretnine365
    {
        public void Procede(IWebDriver driver, string cbKat, string tbNaslov, string tbKvad, string cbSprat, string cbBrSoba, string tbBrKup, string tbCena,bool chS, bool chJ, bool chI, bool chZ, bool chJZ, bool chSZ, bool chSI,bool chJI, string tbGodiste, string cbOpstina, string tbBrLift, string tbGaraza, string cbGrejanje, string tbParking, string rtbOpis)
        {
            driver.Url = "https://www.nekretnine365.com/upis-oglasa.html";

            SelectElement oSelect= new SelectElement(driver.FindElement(By.Id("tree_area_0")));
            oSelect.SelectByText(cbKat);//Tip;

            driver.FindElement(By.Id("next_step")).Click();
            var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/div[2]/input")).Click();

            driver.FindElement(By.XPath("//*[@id='area_title_bs']/input")).SendKeys(tbNaslov);

            driver.FindElement(By.XPath("//*[@id='css_INPUT_2']")).Click();
            var wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            driver.FindElement(By.XPath("//*[@id='sf_field_square_feet']/input")).SendKeys(tbKvad);

            driver.FindElement(By.XPath("//*[@id='sf_field_floor']/input")).SendKeys(cbSprat); // Sprat

            driver.FindElement(By.XPath("//*[@id='sf_field_bedrooms']/input")).SendKeys(cbBrSoba);

            driver.FindElement(By.XPath("//*[@id='sf_field_bathrooms']/input")).SendKeys(tbBrKup);

            driver.FindElement(By.XPath("//*[@id='sf_field_price']/input")).SendKeys(tbCena);

            
            if (chI) { driver.FindElement(By.XPath("//*[@id='css_INPUT_4']")).Click(); }
            if (chZ) { driver.FindElement(By.XPath("//*[@id='css_INPUT_5']")).Click(); }
            if (chS) { driver.FindElement(By.XPath("//*[@id='css_INPUT_6']")).Click(); }
            if (chJ) { driver.FindElement(By.XPath("//*[@id='css_INPUT_7']")).Click(); }
            if (chJI) { driver.FindElement(By.XPath("//*[@id='css_INPUT_8']")).Click(); }
            if (chJZ) { driver.FindElement(By.XPath("//*[@id='css_INPUT_9']")).Click(); }
            if (chSZ) { driver.FindElement(By.XPath("//*[@id='css_INPUT_10']")).Click(); }
            if (chSI) { driver.FindElement(By.XPath("//*[@id='css_INPUT_11']")).Click(); }


            oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id='sf_field_built_in']/select")));
            oSelect.SelectByValue(tbGodiste);

            oSelect= new SelectElement(driver.FindElement(By.XPath("//*[@id='sf_field_country']/select")));
            oSelect.SelectByValue("location_serbia");

            oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id='sf_field_country_level1']/select")));
            oSelect.SelectByValue("location_serbia_srbija_centralna_srbija");

            oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id='sf_field_country_level2']/select")));
            oSelect.SelectByValue("location_serbia_srbija_centralna_srbija_nis");

            driver.FindElement(By.XPath("//*[@id='sf_field_quarter']/input")).SendKeys(cbOpstina);

            if ("Centralno(CG)" == cbGrejanje) { driver.FindElement(By.XPath("//*[@id='css_INPUT_61']")).Click(); }

            if (int.Parse(tbBrLift)>0) { driver.FindElement(By.XPath("//*[@id='css_INPUT_57']")).Click(); }

            if (int.Parse(tbGaraza) > 0) { driver.FindElement(By.XPath("//*[@id='css_INPUT_79']")).Click(); }

            if(int.Parse(tbParking)>0){ driver.FindElement(By.XPath("//*[@id='sf_field_parkingno']/input")).SendKeys(tbParking); }

            driver.FindElement(By.XPath("//*[@id='cke_1_contents']")).SendKeys(rtbOpis);

            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/div[2]/div[2]/div/div[1]/div/input[1]")).SendKeys("zmajvukasin@gmail.com");

            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/div[2]/div[2]/div/div[1]/div/input[2]")).SendKeys("daca2012");

            driver.FindElement(By.XPath("//*[@id='recaptcha-anchor']/div[5]")).Click();

            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            driver.FindElement(By.XPath("//*[@id='controller_area']/div/form/span/input")).Submit();
        }
    }
}

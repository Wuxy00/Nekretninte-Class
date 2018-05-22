/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : RelaticaLogin.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill Relatica.com
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
    class Relatica
    {
        public void Procede(IWebDriver driver,string cbKat, string cbOpstina, string tbArea, string tbPrice, string year, string cbBrojSoba,string bathroom,string m2,string tbDvoriste,string desc)
        {
            driver.Url = "https://www.realitica.com/index.php?action=edit_my_listings&edit=0&lng=hr";
            SelectElement oSelectProdaja = new SelectElement(driver.FindElement(By.Id("klasa")));
            oSelectProdaja.SelectByValue("Prodaja");
            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("typef"))); //CBKAT
            if (cbKat == "Stan")
                oSelectTip.SelectByValue("Apartment");
            else if (cbKat == "Plac")
                oSelectTip.SelectByValue("Land");
            else if (cbKat == "Kuća")
                oSelectTip.SelectByValue("Home");
            else if (cbKat == "Poslovni prostor")
                oSelectTip.SelectByValue("Commercial");
            else { };
            SelectElement oSelectZemlja = new SelectElement(driver.FindElement(By.Id("country")));
            oSelectZemlja.SelectByValue("Serbia");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            SelectElement oSelectGrad = new SelectElement(driver.FindElement(By.Id("region")));
            oSelectZemlja.SelectByText("Niš"); /// BUg FIXXXXX TODO!!!!!!
            var wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            SelectElement oSelectOpstina = new SelectElement(driver.FindElement(By.Id("municipality"))); // OPŠTINA
            if (cbOpstina == "Crveni krst")
                oSelectTip.SelectByValue("040911");
            else if (cbKat == "Medijana")
                oSelectTip.SelectByValue("040908");
            else if (cbKat == "Niška Banja")
                oSelectTip.SelectByValue("040912");
            else if (cbKat == "Palilula")
                oSelectTip.SelectByValue("040909");
            else if (cbKat == "Pantelej")
                oSelectTip.SelectByValue("040910");
            else { };
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            driver.FindElement(By.XPath("//*[@id='content_holder']/table/tbody/tr[6]/td/form/table/tbody/tr[6]/td[2]/input")).SendKeys(tbArea);
            driver.FindElement(By.XPath("//*[@id='content_holder']/table/tbody/tr[6]/td/form/table/tbody/tr[8]/td/p/input")).Submit();
            //Second Page
            driver.FindElement(By.Id("price")).SendKeys(tbPrice);
            driver.FindElement(By.Id("year_built")).SendKeys(year);
            driver.FindElement(By.Id("beds")).SendKeys(cbBrojSoba);
            driver.FindElement(By.Id("baths")).SendKeys(bathroom);
            driver.FindElement(By.Id("sq_meters")).SendKeys(m2);
            if (cbKat == "Kuća") { driver.FindElement(By.Id("lot_size")).SendKeys(tbDvoriste); };
            driver.FindElement(By.XPath("//*[@id='content_holder']/table/tbody/tr[16]/td[2]/textarea")).SendKeys(desc);
            driver.FindElement(By.XPath("//*[@id='content_holder']/table/tbody/tr[23]/td/input")).Submit();
        }
    }
}

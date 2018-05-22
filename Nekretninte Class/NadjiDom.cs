/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : NadjiDom.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill Nadji Dom
 *               
 *
 *****************************************************************************/

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    class NadjiDom
    {
        public void Procede(IWebDriver driver, string DeoGrada, string adress, string adressNumber, string m2, string Combobox1Prvi, string tbPrice, string desc, string bathroom, string terrace, string year, string Combobox2Sprat, string tbDvoriste, string cbBrSoba, string grejanje)
        {
            driver.Url = "http://www.nadjidom.com/sr/my-real-estate-ads&action=add";
            SelectElement selectNamena = new SelectElement(driver.FindElement(By.Id("id_ad_type")));
            selectNamena.SelectByValue("1");//Prodaja
            driver.FindElement(By.Id("ad_title")).SendKeys(DeoGrada + " " + adress + " " + m2);//Naslov

            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("id_type")));
            oSelectTip.SelectByText(Combobox1Prvi);//Tip

            driver.FindElement(By.Id("price")).SendKeys(tbPrice);//Cena

            SelectElement oSelectDrzava = new SelectElement(driver.FindElement(By.Id("id_city_ad")));
            oSelectDrzava.SelectByValue("3");//Nis

            driver.FindElement(By.Id("surface")).SendKeys(m2);//povrsina

            if (tbDvoriste != "") { driver.FindElement(By.Id("land_surface")).SendKeys(tbDvoriste); } // DVORISTE

            SelectElement oSelectBrSoba = new SelectElement(driver.FindElement(By.Id("nb_rooms")));
            oSelectDrzava.SelectByValue(cbBrSoba);//Broj Soba
            
            SelectElement oSelectBrKupatila = new SelectElement(driver.FindElement(By.Id("nb_baths")));
            oSelectDrzava.SelectByValue(bathroom);//Broj Kupatila

            SelectElement oSelectGrejanje = new SelectElement(driver.FindElement(By.Id("id_heating")));
            oSelectDrzava.SelectByValue(grejanje);//Grejanje

            driver.FindElement(By.Id("year_construction")).SendKeys(year); // Godina

            driver.FindElement(By.Id("floor")).SendKeys(Combobox2Sprat); // Sprat

            driver.FindElement(By.Id("tinymce")).SendKeys(desc);// opis
            /*
                Check Box TODOOOOOOOO
                driver.FindElement(By.Id("teraseTxt")).SendKeys(terrace);
            */
            driver.FindElement(By.XPath("//*[@id='tab1_content']/div/input")).Submit(); // submit
        }
    }
}

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
    class FNadjiDom
    {
        public void Procede(IWebDriver driver,string tbNaslov, string DeoGrada, string m2, string Combobox1Prvi, string tbPrice, string desc, string bathroom, string terrace, string year, string Combobox2Sprat, string tbDvoriste, string cbBrSoba, string grejanje,string tbBrLifta, string cbUknjizeno,string tbPrikTel,bool chPodrum, string tbParking,string tbGaraza, string tbBrInterfon)
        {
            driver.Url = "http://www.nadjidom.com/sr/my-real-estate-ads&action=add";
            SelectElement selectNamena = new SelectElement(driver.FindElement(By.Id("id_ad_type")));
            selectNamena.SelectByValue("1");//Prodaja
            driver.FindElement(By.Id("ad_title")).SendKeys(tbNaslov);//Naslov

            SelectElement oSelectTip = new SelectElement(driver.FindElement(By.Id("id_type")));
            oSelectTip.SelectByText(Combobox1Prvi);//Tip

            driver.FindElement(By.Id("price")).SendKeys(tbPrice);//Cena

            SelectElement oSelectDrzava = new SelectElement(driver.FindElement(By.Id("id_city_ad")));
            oSelectDrzava.SelectByValue("3");//Nis

            driver.FindElement(By.Id("surface")).SendKeys(m2);//povrsina

            if (tbDvoriste != "") { driver.FindElement(By.Id("land_surface")).SendKeys(tbDvoriste); } // DVORISTE

            SelectElement oSelectBrSoba = new SelectElement(driver.FindElement(By.Id("nb_rooms")));//TODO BUG FIX
            oSelectDrzava.SelectByText(cbBrSoba);//Broj Soba
            
            SelectElement oSelectBrKupatila = new SelectElement(driver.FindElement(By.Id("nb_baths")));
            oSelectDrzava.SelectByValue(bathroom);//Broj Kupatila

            SelectElement oSelectGrejanje = new SelectElement(driver.FindElement(By.Id("id_heating")));
            oSelectDrzava.SelectByValue(grejanje);//Grejanje

            driver.FindElement(By.Id("year_construction")).SendKeys(year); // Godina

            driver.FindElement(By.Id("floor")).SendKeys(Combobox2Sprat); // Sprat

            driver.FindElement(By.Id("tinymce")).SendKeys(desc);// opis

            if (int.Parse(tbBrLifta) > 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[1]/label")).Click(); } //lift
            if (int.Parse(terrace) > 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[6]/label")).Click(); }   // terasa
            if (cbUknjizeno == "Jeste") { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[16]/label")).Click(); }  // uknjizeno
            if (int.Parse(tbPrikTel) >0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[13]/label")).Click(); } // telefon
            if (int.Parse(tbDvoriste) != 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[4]/label")).Click(); } // dvoriste
            if (chPodrum) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[4]/label")).Click(); } // podrum
            if (int.Parse(tbParking) > 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[2]/label")).Click(); } // parking
            if (int.Parse(tbGaraza) > 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[3]/label")).Click(); } // garaza
            if (int.Parse(tbBrInterfon) > 0) { driver.FindElement(By.XPath("//*[@id='details_row']/ul/li/div[15]/label")).Click(); } // interfon
  driver.FindElement(By.XPath("//*[@id='tab1_content']/div/input")).Submit(); // submit
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class FFacebook
    {
        public void Proccede(IWebDriver driver, string Naslov, string DeoGrada, string m2, string Combobox1Prvi, string tbPrice, string desc, string bathroom, string terrace, string year, string Combobox2Sprat, string cbGrejanje, string cbBrSoba)
        {
            string s = null;
            s += Naslov;
            s += Environment.NewLine;
            s += DeoGrada;
            s += Environment.NewLine;
            s += m2+"metara kvadratnih";
            s += Environment.NewLine;
            s += Combobox1Prvi;
            s += Environment.NewLine;
            s += "Cena: " + tbPrice;
            s += Environment.NewLine;
            s += "Broj kupatila: " + bathroom;
            s += Environment.NewLine;
            s += "Broj terasa: " + terrace;
            s += Environment.NewLine;
            s += "Sprat: " + Combobox2Sprat;
            s += Environment.NewLine;
            s += "Godina izgradnje: " + year;
            s += Environment.NewLine;
            s += "Grejanje: " + cbGrejanje;
            s += Environment.NewLine;
            s += "Broj soba: " + cbBrSoba;
            s += Environment.NewLine;
            s += "Dodatni opis : "+desc;
            //driver.FindElement(By.XPath("//*[@id='js_1l']/div[1]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div/div/div")).SendKeys(s);
            ////*[@id="js_8u"]/div[1]/div/div[1]/div[2]/div/div/div
        }
    }
}

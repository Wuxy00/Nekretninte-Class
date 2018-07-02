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
        public void Proccede(IWebDriver driver, string Naslov, /*string DeoGrada,*/ string m2, string Combobox1Prvi, string tbPrice, string desc, string bathroom, string terrace, string year, string Combobox2Sprat, string cbGrejanje, string cbBrSoba)
        {
            string s = null;
            s += Naslov;
            s += Environment.NewLine;
            //s += DeoGrada;
            //s += Environment.NewLine;
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
            driver.FindElement(By.CssSelector("#js_12 > div._i-o._2j7c > div > div.clearfix._ikh > div._4bl9 > div > div > div")).SendKeys(s);
                
        }
    }
}

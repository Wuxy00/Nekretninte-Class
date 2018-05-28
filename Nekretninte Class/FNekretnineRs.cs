/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : FNekretnineRs.cs
 *
 * Created By  : Dimitrije Iskrenović
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : Fill nekretnine.rs
 *               
 *
 *****************************************************************************/
using OpenQA.Selenium;

namespace Nekretninte_Class
{
    class FNekretnineRs
    {
        public void Proceed(IWebDriver driver)
        {
            driver.Url = "https://www.nekretnine.rs/member/Insertion/";
            PublicVar.WaitUntilElementExists(driver, By.XPath("//*[@id='instructionWrapper']/div[2]/a"), 15).Submit();            
        }
    }
}

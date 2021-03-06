﻿/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : Login.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : User interface call login class
 *               
 *
 *****************************************************************************/
using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Nekretninte_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Start program by loging in 4zida.rs

            WebDriverWait wait = new WebDriverWait(PublicVar.driver, TimeSpan.FromSeconds(5));

            //Login CetriZida = new Login();
            //CetriZida.Setup(PublicVar.driver, "https://www.4zida.rs/login");

            //CetriZida.ProccedID(PublicVar.driver, "kodeksimovina@mts.rs", "12345678", "//*[@id='username']", "//*[@id='password']", "end-buttons");//BUGFIX LOGIN

            //Login Relatica = new Login();
            //Relatica.Setup(PublicVar.driver, "https://www.realitica.com/index.php?action=member_login&lng=hr");
            //Relatica.Procced(PublicVar.driver, "iskrenovic@yahoo.com", "1DvaTri4", "//*[@id='content_holder']/form[1]/table/tbody/tr[1]/td[2]/input", "//*[@id='content_holder']/form[1]/table/tbody/tr[2]/td[2]/input", "//*[@id='content_holder']/form[1]/table/tbody/tr[4]/td/input");

            //Login Nekretnine365 = new Login();
            //Nekretnine365.Setup(PublicVar.driver, "https://www.nekretnine365.com/login.html");
            //Nekretnine365.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='controller_area']/div/form/input[2]", "//*[@id='controller_area']/div/form/input[3]", "//*[@id='controller_area']/div/form/div[2]/input");

            //Login NadjiDom = new Login();
            //NadjiDom.Setup(PublicVar.driver, "http://www.nadjidom.com/sr/login");
            //wait = new WebDriverWait(PublicVar.driver, TimeSpan.FromSeconds(2));
            //NadjiDom.Procced(PublicVar.driver, "iskrenovic@yahoo.com", "1DvaTri4", "//*[@id='login_username']", "//*[@id='login_password']", "//*[@id='loginForm']/div[4]/input");

            //Login MojTrg = new Login();
            //MojTrg.Setup(PublicVar.driver, "https://www.mojtrg.rs/Dispatcher/Render?incView=~%2FViews%2FAccount%2FSignIn.cshtml");
            //MojTrg.Procced(PublicVar.driver, "kodeksimovina@open.telekom.rs", "1DvaTri4", "//*[@id='Email']", "//*[@id='Password']", "/html/body/section/div[1]/div/div[1]/div[1]/form/div[2]/div/div[1]/input");

            //Login Indomio = new Login();
            //Indomio.Setup(PublicVar.driver, "https://crm.indomio.com/sr/login");
            //Indomio.Procced(PublicVar.driver, "dmilosevic252@gmail.com", "daca2012", "//*[@id='fieldEmail']", "//*[@id='fieldPassword']", "//*[@id='form-login']/button");

            //Login SrbijaNekretnine = new Login();
            //SrbijaNekretnine.Setup(PublicVar.driver, "https://srbija-nekretnine.org/agencija/registracija?oglas=1");
            //SrbijaNekretnine.ProccedByPass(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='UsernameTxt']", "//*[@id='PasswordTxt']", "//*[@id='prijaviBtn']", "//*[@id='integrityPrijavaTxt']");

            //Login NekretnineRs = new Login();
            //NekretnineRs.Setup(PublicVar.driver, "https://www.nekretnine.rs/");
            //NekretnineRs.ProceedClickAndWait(PublicVar.driver, "iskrenovic@yahoo.com", "1DvaTri4", "/html/body/div[5]/div/div/ul/li[2]/a/span", "//*[@id='login_email']", "//*[@id='login_pwd']", "/html/body/div[15]/div/div/div[2]/div/form/div[4]/div[2]/button");

            //Login Facebook = new Login();
            //Facebook.Setup(PublicVar.driver, "https://www.facebook.com");
            //Facebook.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='email']", "//*[@id='pass']", "//*[@id='u_0_2']");

            //Login HaloOglasi = new Login();
            //HaloOglasi.Setup(PublicVar.driver, "https://www.halooglasi.com/prijava?returnUrl=%2f");
            //HaloOglasi.Procced(PublicVar.driver, "iskrenovic@yahoo.com", "1DvaTri4", "//*[@id='EMailOrUsername']", "//*[@id='Password']", "//*[@id='__AjaxAntiForgeryForm']/div[3]/div[2]/button");

            //Login imovina = new Login();
            //imovina.Setup(PublicVar.driver, "https://imovina.net/prijava_i_registracija/");
            //imovina.Procced(PublicVar.driver, "kodeks", "1dvatri4", "//*[@id='mailId']", "//*[@id='passId']", "//*[@id='formLogin']/div[1]/input");

            //Login webNekretnine = new Login();
            //webNekretnine.Setup(PublicVar.driver, "https://www.webnekretnine.net/member_login.php");
            //webNekretnine.Procced(PublicVar.driver, "kodeksimovina@mts.rs", "1DvaTri4", "//*[@id='tab3col']/table[2]/tbody/tr[2]/td[1]/table/tbody/tr/td/table/tbody/tr[2]/td/form/p[1]/input[2]", "//*[@id='tab3col']/table[2]/tbody/tr[2]/td[1]/table/tbody/tr/td/table/tbody/tr[2]/td/form/p[2]/input[1]", "//*[@id='tab3col']/table[2]/tbody/tr[2]/td[1]/table/tbody/tr/td/table/tbody/tr[2]/td/form/p[2]/input[2]");

            //Login imovina = new Login();
            //imovina.Setup(PublicVar.driver, "https://imovina.net/prijava_i_registracija/");
            //imovina.Procced(PublicVar.driver, "kodeks", "1dvatri4", "//*[@id='mailId']", "//*[@id='passId']", "//*[@id='formLogin']/div[1]/input");

            //Login kupujemProdajem = new Login();
            //kupujemProdajem.Setup(PublicVar.driver, "https://www.kupujemprodajem.com/user.php?action=login");            
            //kupujemProdajem.Procced(PublicVar.driver, "prokopije69@yahoo.com", "1DvaTri4", "//*[@id='loginForm']/table/tbody/tr/td/div[2]/table/tbody/tr[1]/td[2]/input", "//*[@id='loginForm']/table/tbody/tr/td/div[2]/table/tbody/tr[2]/td[2]/input", "//*[@id='loginForm']/table/tbody/tr/td/div[2]/table/tbody/tr[4]/td/input");

            Login srne = new Login();
            srne.Setup(PublicVar.driver, "http://www.srne.rs/login/");            
            srne.Procced(PublicVar.driver, "kodeksimovina@open.telekom.rs", "1DvaTri4", "//*[@id='content']/div[2]/form/input[1]", "//*[@id='content']/div[2]/form/input[2]", "//*[@id='content']/div[2]/form/div[2]/a[1]/span");

            Form2 form2 = new Form2(); // Nextform
            form2.Show();
            this.Hide();

        }
    }
}

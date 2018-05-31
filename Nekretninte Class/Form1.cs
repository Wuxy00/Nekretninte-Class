/*****************************************************************************
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

                //Login CetriZida = new Login();
                //CetriZida.Setup(PublicVar.driver, "https://www.4zida.rs/login");
                //var wait = new WebDriverWait(PublicVar.driver, TimeSpan.FromSeconds(5));
                //CetriZida.ProccedID(PublicVar.driver, textBox1.Text, textBox2.Text,"//*[@id='username']", "//*[@id='password']", "end-buttons");//BUGFIX LOGIN
   
                //Login Relatica = new Login();
                //Relatica.Setup(PublicVar.driver, "https://www.realitica.com/index.php?action=member_login&lng=hr");
                //Relatica.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='content_holder']/form[1]/table/tbody/tr[1]/td[2]/input", "//*[@id='content_holder']/form[1]/table/tbody/tr[2]/td[2]/input", "//*[@id='content_holder']/form[1]/table/tbody/tr[4]/td/input");

                //Login Nekretnine365 = new Login();
                //Nekretnine365.Setup(PublicVar.driver, "https://www.nekretnine365.com/login.html");
                //Nekretnine365.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='controller_area']/div/form/input[2]", "//*[@id='controller_area']/div/form/input[3]", "//*[@id='controller_area']/div/form/div[2]/input");

                //Login NadjiDom = new Login();
                //NadjiDom.Setup(PublicVar.driver, "http://www.nadjidom.com/sr/login");
                //wait = new WebDriverWait(PublicVar.driver, TimeSpan.FromSeconds(2));
                //NadjiDom.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='login_username']", "//*[@id='login_password']", "//*[@id='loginForm']/div[4]/input");

                //Login MojTrg = new Login();
                //MojTrg.Setup(PublicVar.driver, "https://www.mojtrg.rs/Dispatcher/Render?incView=~%2FViews%2FAccount%2FSignIn.cshtml");
                //MojTrg.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='Email']", "//*[@id='Password']", "/html/body/section/div[1]/div/div[1]/div[1]/form/div[2]/div/div[1]/input");


                //Login Indomio = new Login();
                //Indomio.Setup(PublicVar.driver, "https://crm.indomio.com/sr/login");
                //Indomio.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='fieldEmail']", "//*[@id='fieldPassword']", "//*[@id='form-login']/button");

                //Login SrbijaNekretnine = new Login();
                //SrbijaNekretnine.Setup(PublicVar.driver, "https://srbija-nekretnine.org/agencija/registracija?oglas=1");
                //SrbijaNekretnine.ProccedByPass(PublicVar.driver, textBox1.Text, textBox2.Text, "//*[@id='UsernameTxt']", "//*[@id='PasswordTxt']", "//*[@id='prijaviBtn']", "//*[@id='integrityPrijavaTxt']");

            Login NekretnineRs = new Login();
            NekretnineRs.Setup(PublicVar.driver, "https://www.nekretnine.rs/");
            NekretnineRs.ProccedByPassDica(PublicVar.driver, textBox2.Text);
            
            //LSrbijaNekretnineByPass startSecond = new LSrbijaNekretnineByPass();
            //startSecond.Setup(PublicVar.driver1);
            //startSecond.Procede(PublicVar.driver1, textBox1.Text, textBox2.Text);

            ////startSecond.End();
            ////Start program by loging in Srbija - nadjidom.com

            //LNadjiDomLogin startThird = new LNadjiDomLogin();
            //startThird.Setup(PublicVar.driver2);
            //startThird.Procced(PublicVar.driver2, textBox1.Text, textBox2.Text);

            ////startThird.End();
            ////Start program by loging in Srbija - relatica.com

            //LRelaticaLogin startFour = new LRelaticaLogin();
            //startFour.Setup(PublicVar.driver3);
            //startFour.Procede(PublicVar.driver3, textBox1.Text, textBox2.Text);

            ////startFour.End();

            //LMojTrg startFive = new LMojTrg();
            //startFive.Setup(PublicVar.driver4);
            //startFive.Procede(PublicVar.driver4, textBox1.Text, textBox2.Text);

            ////startFive.End();

            //LIndomio startSix = new LIndomio();
            //FIndomio popuni = new FIndomio();
            //startSix.Setup(PublicVar.driver5);
            //startSix.Procede(PublicVar.driver5, textBox1.Text, textBox2.Text);
            //popuni.Procede(PublicVar.driver5, "Palilula", "Garaza", "Lalinac", "TA", true, "1967", "U izgradnji", 1000, "5");

            ////startSix.End();
            ////Start loging on Nekretnine365.com

            //LNekretnine365 startSeven = new LNekretnine365();
            //startSeven.Setup(PublicVar.driver6);
            //startSeven.Procede(PublicVar.driver6, textBox1.Text, textBox2.Text);

            //startSeven.End();

            //LNekretnineRs startEight = new LNekretnineRs();
            //startEight.Setup(PublicVar.driver7);
            //startEight.Proceed(PublicVar.driver7, textBox2.Text);

            Form2 form2 = new Form2(); // Nextform
            form2.Show();
            this.Hide();

        }
    }
}

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
            Login start = new Login();
            start.Setup(PublicVar.driver);
            start.Procced(PublicVar.driver, textBox1.Text, textBox2.Text);
            //start.End();
            //Start program by loging in Srbija - nekretnine.org           
            LSrbijaNekretnineByPass startSecond = new LSrbijaNekretnineByPass();
            startSecond.Setup(PublicVar.driver1);
            startSecond.Procede(PublicVar.driver1, textBox1.Text, textBox2.Text);
            ////startSecond.End();
            ////Start program by loging in Srbija - nadjidom.com
            LNadjiDomLogin startThird = new LNadjiDomLogin();
            startThird.Setup(PublicVar.driver2);
            startThird.Procced(PublicVar.driver2, textBox1.Text, textBox2.Text);
            //startThird.End();
            //Start program by loging in Srbija - relatica.com
            LRelaticaLogin startFour = new LRelaticaLogin();
            startFour.Setup(PublicVar.driver3);
            startFour.Procede(PublicVar.driver3, textBox1.Text, textBox2.Text);
            //startFour.End();
            LMojTrg startFive = new LMojTrg();
            startFive.Setup(PublicVar.driver4);
            startFive.Procede(PublicVar.driver4, textBox1.Text, textBox2.Text);
            Form2 form2 = new Form2(); // Nextform
            form2.Show();
            this.Hide();

        }
    }
}

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
            //Start program by loging in Srbija - nekretnine.org
            SrbijaNekretnineByPass startSecond = new SrbijaNekretnineByPass();
            startSecond.Setup(PublicVar.driver1);
            startSecond.Procede(PublicVar.driver1, textBox1.Text, textBox2.Text);
            //start.End();
            Form2 form2 = new Form2(); // Nextform
            form2.Show();
            this.Hide();

        }
    }
}

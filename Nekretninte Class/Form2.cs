/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : Form2.cs
 *
 * Created By  : Vukašin Stamenković
 *
 * Based On    : 
 *
 * Hardware    :
 *
 * Description : All User input work
 *               
 *
 *****************************************************************************/
using System;
using System.Windows.Forms;

namespace Nekretninte_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] paths = new string[100];
        private void button1_Click(object sender, EventArgs e)
        {
            SelectFromStructureGroup1 startSelection = new SelectFromStructureGroup1(); // Select type of selling place
            startSelection.Setup(PublicVar.driver);
            //startSelection.Procced(PublicVar.driver,comboBox1.SelectedText); // TO DOOOOO
            PlaceCategory FirstQA = new PlaceCategory();
            //FirstQA.Procced(PublicVar.driver, comboBox2.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllTextInputForms EneterPrice = new AllTextInputForms();
            EneterPrice.Procced(PublicVar.driver, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text, textBox19.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kuca")
            {
                textBox16.Hide();
                textBox17.Hide();
                textBox18.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();

            }
            else if(comboBox1.Text == "Poslovni prostor")
            {
                textBox16.Hide();
                textBox17.Hide();
                textBox20.Hide();
                textBox18.Hide();
                label16.Hide();
                label18.Hide();
                label17.Hide();
                label20.Hide();
            }
            else if(comboBox1.Text == "Plac")
            {
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();
                textBox6.Hide();
                textBox7.Hide();
                textBox8.Hide();
                textBox9.Hide();
                textBox10.Hide();
                textBox11.Hide();
                textBox12.Hide();
                textBox13.Hide();
                textBox14.Hide();
                textBox15.Hide();
                textBox16.Hide();
                textBox17.Hide();
                textBox20.Hide();
                textBox18.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();
                label20.Hide();
            }
            else if(comboBox1.Text == "Garaza")
            {
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();
                label20.Hide();
                textBox6.Hide();
                textBox7.Hide();
                textBox8.Hide();
                textBox9.Hide();
                textBox10.Hide();
                textBox11.Hide();
                textBox12.Hide();
                textBox13.Hide();
                textBox14.Hide();
                textBox15.Hide();
                textBox16.Hide();
                textBox17.Hide();
                textBox18.Hide();
                textBox20.Hide();
            }
            else
            {
                label20.Hide();
                textBox20.Hide();
            }
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg";
            DialogResult dig = openFileDialog1.ShowDialog();
            if (dig == DialogResult.OK)
            {
                paths[i] = dig.ToString();
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UploadPicture PicOnSite = new UploadPicture();
            //PicOnSite.Setup(PublicVar.driver);
            PicOnSite.Procced(PublicVar.driver, paths,i);
            PicOnSite.Submit(PublicVar.driver);
        }
    }
}

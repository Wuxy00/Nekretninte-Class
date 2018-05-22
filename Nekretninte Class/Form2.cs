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

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFromStructureGroup1 startSelection = new SelectFromStructureGroup1(); // Select type of selling place
            startSelection.Setup(PublicVar.driver);
            PlaceCategory FirstQA = new PlaceCategory();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            CetriZida cetriZida = new CetriZida();
            cetriZida.Proceed(PublicVar.driver, tbCena.Text, tbKvad.Text, tbArea.Text, tbAdresa.Text, tbBroj.Text, tbGodiste.Text, tbBrojLodja.Text, tbBrojTerasa.Text, tbPrikTel.Text, tbBrInterfon.Text, tbBrLift.Text, tbBrKup.Text, tbToal.Text, tbParking.Text, tbGaraza.Text, tbAutobus.Text, tbTramvaj.Text, tbTrolejbus.Text, rtbOpis.Text);
            //cetriZida.ProceedMultipleChoice(PublicVar.driver,)
            SrbijaNekretnineOglas EnterAllSrbiaNek = new SrbijaNekretnineOglas();
            EnterAllSrbiaNek.Procede(PublicVar.driver1, tbArea.Text, tbAdresa.Text, tbBroj.Text, tbKvad.Text, cbKat.Text, tbCena.Text, rtbOpis.Text, tbBrKup.Text, tbBrojTerasa.Text, tbGodiste.Text, comboBox1.Text);
            NadjiDom EnterAllNadjiDom = new NadjiDom();
            EnterAllNadjiDom.Procede(PublicVar.driver2, tbArea.Text, tbAdresa.Text, tbBroj.Text, tbKvad.Text, comboBox2.Text, tbCena.Text, rtbOpis.Text, tbBrKup.Text, tbBrojTerasa.Text, tbGodiste.Text, cbSprat.Text, tbDvoriste.Text, cbBrSoba.Text, cbGrejanje.Text);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VratiNaDefault();
            if (cbKat.Text == "Kuca")
            {
                tbAutobus.Hide();
                tbTramvaj.Hide();
                tbTrolejbus.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();

            }
            else if(cbKat.Text == "Poslovni prostor")
            {
                tbAutobus.Hide();
                tbTramvaj.Hide();
                tbDvoriste.Hide();
                tbTrolejbus.Hide();
                label16.Hide();
                label18.Hide();
                label17.Hide();
                label20.Hide();
            }
            else if(cbKat.Text == "Plac")
            {
                tbCena.Show();
                tbKvad.Show();
                tbArea.Show();
                tbAdresa.Show();
                tbBroj.Show();
                tbGodiste.Show();
                tbBrojLodja.Show();
                tbBrojTerasa.Show();
                tbPrikTel.Show();
                tbGodiste.Hide();
                tbBrojLodja.Hide();
                tbBrojTerasa.Hide();
                tbPrikTel.Hide();
                tbBrInterfon.Hide();
                tbBrLift.Hide();
                tbBrKup.Hide();
                tbToal.Hide();
                tbParking.Hide();
                tbGaraza.Hide();
                tbAutobus.Hide();
                tbTramvaj.Hide();
                tbDvoriste.Hide();
                tbTrolejbus.Hide();
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
            else if(cbKat.Text == "Garaza")
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
                tbGodiste.Hide();
                tbBrojLodja.Hide();
                tbBrojTerasa.Hide();
                tbPrikTel.Hide();
                tbBrInterfon.Hide();
                tbBrLift.Hide();
                tbBrKup.Hide();
                tbToal.Hide();
                tbParking.Hide();
                tbGaraza.Hide();
                tbAutobus.Hide();
                tbTramvaj.Hide();
                tbTrolejbus.Hide();
                tbDvoriste.Hide();
            }
            else
            {
                label20.Hide();
                tbDvoriste.Hide();
            }
        }
        private void VratiNaDefault()
        {
            tbCena.Show();
            tbKvad.Show();
            tbArea.Show();
            tbAdresa.Show();
            tbBroj.Show();
            tbGodiste.Show();
            tbBrojLodja.Show();
            tbBrojTerasa.Show();
            tbPrikTel.Show();
            tbGodiste.Show();
            tbBrojLodja.Show();
            tbBrojTerasa.Show();
            tbPrikTel.Show();
            tbBrInterfon.Show();
            tbBrLift.Show();
            tbBrKup.Show();
            tbToal.Show();
            tbParking.Show();
            tbGaraza.Show();
            tbAutobus.Show();
            tbTramvaj.Show();
            tbDvoriste.Show();
            tbTrolejbus.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
            label16.Show();
            label17.Show();
            label18.Show();
            label20.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 loginScreen = new Form1();
            loginScreen.Show();
        }
        UploadPics PicOnSite = new UploadPics();
        private void button3_Click(object sender, EventArgs e)
        {
                PicOnSite.Submit(PublicVar.driver);
        }
    }
}

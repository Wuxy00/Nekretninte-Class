/*****************************************************************************
 * Copyright 2018
 *****************************************************************************
 *
 * Filename    : Form2.cs
 *
 * Created By  : Vukašin Stamenković && Dimitrije Iskrenović
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
            //TODOOOOOO bug 4zida.rs login drugaciji od drugih // NeMenjaNISSTA!!!!!!!!!!!!!! u ovom BUTTON-u!!!!!!! // ZASTO DA NE MENJEMA PEDERUUUU //Zato sto nista ne valja i treba se promeni ali nemo ti jer sam taj button ja pravio
            SelectFromStructureGroup1 startSelection = new SelectFromStructureGroup1(); // Select type of selling place
            startSelection.Setup(PublicVar.driver);
            PlaceCategory FirstQA = new PlaceCategory();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CetriZida cetriZida = new CetriZida();
            //cetriZida.Proceed(PublicVar.driver, tbCena.Text, tbKvad.Text, tbArea.Text, /*tbAdresa.Text, tbBroj.Text,*/ tbGodiste.Text, tbBrojLodja.Text, tbBrojTerasa.Text, tbPrikTel.Text, tbBrInterfon.Text, tbBrLift.Text, tbBrKup.Text, tbToal.Text, tbParking.Text, tbGaraza.Text, /*tbAutobus.Text, tbTramvaj.Text, tbTrolejbus.Text,*/ rtbOpis.Text);
            //cetriZida.ProceedMultipleChoice(PublicVar.driver, cbGrupa.SelectedIndex, cbPurpose.SelectedIndex, cbBrSoba.SelectedIndex, cbUknjizeno.SelectedIndex, cbStanje.SelectedIndex, cbSprat.SelectedIndex, cbGrejanje.SelectedIndex);
            //FSrbijaNekretnineOglas EnterAllSrbiaNek = new FSrbijaNekretnineOglas();
            //EnterAllSrbiaNek.Procede(PublicVar.driver, tbNaslov.Text, tbArea.Text/*, tbAdresa.Text, tbBroj.Text*/, tbKvad.Text, cbKat.Text, tbCena.Text, rtbOpis.Text, tbBrKup.Text, tbBrojTerasa.Text, tbGodiste.Text, cbSprat.Text,cbGrejanje.Text, cbBrSoba.Text);
            //UploadPics relatica = new UploadPics();
            //relatica.Submit(PublicVar.driver,"//*[@id='dodaj - fotografiju']","");
            //FNadjiDom EnterAllNadjiDom = new FNadjiDom();
            ////EnterAllNadjiDom.Procede(PublicVar.driver2, tbNaslov.Text, tbArea.Text, tbKvad.Text, cbGrupa.Text, tbCena.Text, rtbOpis.Text, tbBrKup.Text, tbBrojTerasa.Text, tbGodiste.Text, cbSprat.Text, tbDvoriste.Text, cbBrSoba.Text, cbGrejanje.Text,tbBrLift.Text,cbUknjizeno.Text, tbPrikTel.Text,chPodrum.Checked,tbParking.Text,tbGaraza.Text,tbBrInterfon.Text);
            //FRelatica EnterRelatica = new FRelatica();
            //EnterRelatica.Procede(PublicVar.driver, cbKat.Text, cbOpstina.Text, tbArea.Text, tbCena.Text, tbGodiste.Text, cbBrSoba.Text, tbBrKup.Text, tbKvad.Text, tbDvoriste.Text, rtbOpis.Text);
            //UploadPics relatica = new UploadPics();
            //relatica.Submit(PublicVar.driver, "//*[@id='content_holder']/table[1]/tbody/tr[2]/td[2]/form/input[4]", "https://www.realitica.com/?action=edit_listing_images_get&edit=1593176&lng=hr");

            //FNekretnine365 startSeven = new FNekretnine365();
            //startSeven.Procede(PublicVar.driver, cbKat.Text, tbNaslov.Text, tbKvad.Text, cbSprat.Text, cbBrSoba.Text, tbBrKup.Text, tbCena.Text, chS.Checked, chJ.Checked, chI.Checked, chZ.Checked, chJZ.Checked, chSZ.Checked, chSI.Checked, chJI.Checked, tbGodiste.Text, cbOpstina.Text, tbBrLift.Text, tbGaraza.Text, cbGrejanje.Text, tbParking.Text, rtbOpis.Text);
            //FNekretnineRs EnterNekretnineRs = new FNekretnineRs();
            //EnterNekretnineRs.Setup(PublicVar.driver);
            //EnterNekretnineRs.Proceed(PublicVar.driver,rbIzdavanje.Checked, cbOkrug.Text);
            FFacebook fillFace = new FFacebook();
            fillFace.Proccede(PublicVar.driver, tbNaslov.Text, tbArea.Text, tbKvad.Text, cbKat.Text, tbCena.Text, rtbOpis.Text, tbBrKup.Text, tbBrojTerasa.Text, tbGodiste.Text, cbSprat.Text, cbGrejanje.Text, cbBrSoba.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VratiNaDefault();
            if (cbKat.Text == "Kuca")
            {

            }
            else if(cbKat.Text == "Poslovni prostor")
            {
                tbDvoriste.Hide();
                label20.Hide();
            }
            else if(cbKat.Text == "Plac")
            {
                tbCena.Show();
                tbKvad.Show();
                tbArea.Show();
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
                tbDvoriste.Hide();
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
            tbDvoriste.Show();
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
            label20.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 loginScreen = new Form1();
            loginScreen.Show();
        }
        //UploadPics PicOnSite = new UploadPics();
        private void button3_Click(object sender, EventArgs e)
        {
            //PicOnSite.Submit(PublicVar.driver);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

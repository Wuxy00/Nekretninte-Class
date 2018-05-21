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
            Login start = new Login();  // Start program by loging in
            start.Setup(PublicVar.driver);
            start.Procced(PublicVar.driver, textBox1.Text, textBox2.Text);
            //start.End();
            Form2 form2 = new Form2(); // Nextform
            form2.Show();
        }
    }
}

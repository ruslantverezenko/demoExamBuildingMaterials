using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppVariant4
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            
            if(login == "klh7pi4rcbtz@gmail.com" && password == "2L6KZG")
            {
                formAdmin fA = new formAdmin();
                fA.Show();
                FormLogin fL = new FormLogin();
                fL.Close();
            }

        }
    }
}

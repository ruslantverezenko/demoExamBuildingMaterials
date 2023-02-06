using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsAppVariant4
{
    public partial class AddZakazForm : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = DB_MT.mdb";
        private OleDbConnection myConnection;
        public AddZakazForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOrder = Convert.ToInt32(textBox1.Text);
            string sostavZakaza = textBox2.Text;
            string dateOrder = textBox3.Text;
            string dateDelivery = textBox4.Text;
            int punktVidachi = Convert.ToInt32(textBox5.Text);
            string fioClient = textBox6.Text;
            int codeForGetting = Convert.ToInt32(textBox7.Text);
            string statusOrder = textBox8.Text;
            string query = $"INSERT INTO Заказ VALUES({numberOrder}, '{sostavZakaza}', '{dateOrder}', '{dateDelivery}', {punktVidachi}, '{fioClient}', {codeForGetting}, '{statusOrder}')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ добавлен");
        }
    }
}

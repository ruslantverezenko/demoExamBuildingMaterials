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
    public partial class AddTovariForm : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = DB_MT.mdb";
        private OleDbConnection myConnection;
        public AddTovariForm()
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
            int code = Convert.ToInt32(textBox1.Text);
            string article = textBox2.Text;
            string name = textBox3.Text;
            string unitOfMeasurement = textBox4.Text;
            int price = Convert.ToInt32(textBox5.Text);
            int maxDiscount = Convert.ToInt32(textBox6.Text);
            string manufacturer = textBox7.Text;
            string provider = textBox8.Text;
            string categoryProduct = textBox9.Text;
            int nowDiscount = Convert.ToInt32(textBox10.Text);
            int countOnWarehouse = Convert.ToInt32(textBox11.Text);
            string description = textBox12.Text;
            string imageName = textBox13.Text;


            string query = $"INSERT INTO Товары VALUES({code}, '{article}', '{name}', '{unitOfMeasurement}', {price}, {maxDiscount}, '{manufacturer}', '{provider}', '{categoryProduct}', {nowDiscount}, {countOnWarehouse}, '{description}', '{imageName}')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Товар добавлен");
        }
    }
}

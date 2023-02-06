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
    public partial class AddSotrudnikiForm : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = DB_MT.mdb";
        private OleDbConnection myConnection;
        public AddSotrudnikiForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            string role = textBox2.Text;
            string fio = textBox3.Text;
            string login = textBox4.Text;
            string password = textBox5.Text;

            string query = $"INSERT INTO Сотрудники VALUES({code}, '{role}', '{fio}', '{login}', '{password}')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сотрудник добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

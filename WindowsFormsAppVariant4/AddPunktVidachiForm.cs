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
    public partial class AddPunktVidachiForm : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = DB_MT.mdb";
        private OleDbConnection myConnection;
        public AddPunktVidachiForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            string adress = textBox2.Text;

            string query = $"INSERT INTO [Пункты выдачи] VALUES({code}, '{adress}')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Пункт выдачи добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

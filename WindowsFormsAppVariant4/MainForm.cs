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
    public partial class MainForm : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = DB_MT.mdb";
        private OleDbConnection myConnection;
        public MainForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MTDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.dB_MTDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MTDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dB_MTDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MTDataSet.Пункты_выдачи". При необходимости она может быть перемещена или удалена.
            this.пункты_выдачиTableAdapter.Fill(this.dB_MTDataSet.Пункты_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MTDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.dB_MTDataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddZakazForm addZakaz = new AddZakazForm();
            addZakaz.Owner = this;
            addZakaz.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPunktVidachiForm fpunkt = new AddPunktVidachiForm();
            fpunkt.Owner = this;
            fpunkt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddSotrudnikiForm fsotrudniki = new AddSotrudnikiForm();
            fsotrudniki.Owner = this;
            fsotrudniki.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddTovariForm ftovari = new AddTovariForm();
            ftovari.Owner = this;
            ftovari.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int numberOrder = Convert.ToInt32(textBox1.Text);
            string query = $"DELETE FROM Заказ WHERE [Номер заказа]={numberOrder}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о заказе удалены");
            this.заказTableAdapter.Fill(this.dB_MTDataSet.Заказ);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numberOrder = Convert.ToInt32(textBox2.Text);
            string query = $"UPDATE Заказ SET [Статус заказа] ='{textBox3.Text}' WHERE [Номер заказа] = {numberOrder}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Статус заказа обновлен");
            this.заказTableAdapter.Fill(this.dB_MTDataSet.Заказ);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.пункты_выдачиTableAdapter.Fill(this.dB_MTDataSet.Пункты_выдачи);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказTableAdapter.Fill(this.dB_MTDataSet.Заказ);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox4.Text);
            string query = $"DELETE FROM [Пункты выдачи] WHERE Код ={code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о пункте выдачи удалены");
            this.пункты_выдачиTableAdapter.Fill(this.dB_MTDataSet.Пункты_выдачи);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox5.Text);
            string query = $"UPDATE [Пункты выдачи] SET Адрес ='{textBox6.Text}' WHERE Код = {code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Адрес пункта выдачи обновлен");
            this.пункты_выдачиTableAdapter.Fill(this.dB_MTDataSet.Пункты_выдачи);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.dB_MTDataSet.Сотрудники);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox7.Text);
            string query = $"DELETE FROM Сотрудники WHERE Код ={code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике удалены");
            this.сотрудникиTableAdapter.Fill(this.dB_MTDataSet.Сотрудники);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox8.Text);
            string query = $"UPDATE Сотрудники SET Логин ='{textBox9.Text}' WHERE Код = {code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Логин сотрудника обновлен");
            this.сотрудникиTableAdapter.Fill(this.dB_MTDataSet.Сотрудники);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.товарыTableAdapter.Fill(this.dB_MTDataSet.Товары);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox10.Text);
            string query = $"DELETE FROM Товары WHERE Код ={code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о товаре удалены");
            this.товарыTableAdapter.Fill(this.dB_MTDataSet.Товары);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox11.Text);
            int count = Convert.ToInt32(textBox12.Text);
            string query = $"UPDATE Товары SET [Кол-во на складе] = {count}  WHERE Код = {code}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о количестве обновлены");
            this.товарыTableAdapter.Fill(this.dB_MTDataSet.Товары);
        }
    }
}

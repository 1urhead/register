using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register
{

    public partial class Form1 : Form
    {
        Class1 database = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var login = textBox1.Text;
            var password = textBox2.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!", "Ура!");
                Form2 frm_login = new Form2();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            database.closeConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

// 22 project demonstration 

namespace train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= system; password= admin;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= system; password= admin;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= system; password= admin;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP) ( HOST = localhost ) ( PORT = 1521)) (CONNECT_DATA=(SERVER= DEDICATED)( SERVICE_NAME= XE ))); USER ID= system; PASSWORD= admin;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            string n = textBox1.Text;
            string p = textBox3.Text;

            if (n == "")
            {
                MessageBox.Show(" Enter the USER id");
                textBox1.Focus();
            }
            else if (p == "")
            {
                MessageBox.Show("Enter the password");
                textBox3.Focus();
            }
            else if (n == "shivu" && p == "shivu14")
            {
                MessageBox.Show("Valid user account");
                Form2 f1 = new Form2();
                f1.Show();
            }
            else if(n=="shivu" && p == "shivu")
            {
                MessageBox.Show("Valid user account");
                Form7 f7 = new Form7();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Invalid account");
                textBox1.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
            }
        }
    }
}

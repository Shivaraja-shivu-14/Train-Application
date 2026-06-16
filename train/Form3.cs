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

namespace train
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " insert into train values ('  " + textBox1.Text + "   ','    " + textBox2.Text + " ',' " + textBox3.Text + "    ',' " + textBox4.Text + "  ') ";

            cmd.ExecuteNonQuery();

            MessageBox.Show(" Inserted successfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

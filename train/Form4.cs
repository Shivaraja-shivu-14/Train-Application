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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox3.Text;
            string s2 = textBox4.Text;

            textBox4.Text = s1;
            textBox3.Text = s2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";
            string fa = textBox3.Text;
            string ta = textBox4.Text;
            OracleConnection conn = new OracleConnection(s);
            conn.Open();
 
               

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from train where fa='" +fa+ "' and ta='"+ta+"'";
            cmd.Connection = conn;

            OracleDataReader dr = cmd.ExecuteReader();

     
            DataTable tab = new DataTable();
            tab.Load(dr);

            dataGridView1.DataSource = tab;
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

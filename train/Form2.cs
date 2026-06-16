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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from train where tn='"+comboBox1.Text+"'";
            cmd.Connection = conn;
            
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox2.Text = dr.GetString(0).ToString();
                textBox3.Text = dr.GetString(2).ToString();
                textBox4.Text = dr.GetString(3).ToString();
                 
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
         
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

            }
            else
            {
                MessageBox.Show(" Invalid train number");
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= system; password= admin;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
             
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";

            OracleConnection conn = new OracleConnection(s);
            conn.Open();

             OracleCommand cmd = new OracleCommand();
             cmd.CommandText = "select * from train";
             cmd.Connection = conn;
           
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable tab = new DataTable();

            tab.Load(dr);
            dataGridView1.DataSource = tab;

            dataGridView1.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show(); 
        }
    }
}

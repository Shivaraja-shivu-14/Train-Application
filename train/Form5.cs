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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";
            OracleConnection conn = new OracleConnection(s);
            conn.Open();
             
            if (radioButton1.Checked)
            { 
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from veg";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();

                DataTable tab = new DataTable();
                panel1.Visible = false;
                tab.Load(dr);
                dataGridView1.DataSource = tab;
                dataGridView1.Visible = true;
            }
            
            else if (radioButton2.Checked)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from nonveg";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();
                DataTable tab = new DataTable();

                tab.Load(dr);
                dataGridView1.DataSource = tab;
                panel1.Visible = false;
                dataGridView1.Visible = true;
            }

            else
            {
                MessageBox.Show(" Select any Item ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";
            OracleConnection conn = new OracleConnection(s);
            conn.Open();

           
        }

    }
}

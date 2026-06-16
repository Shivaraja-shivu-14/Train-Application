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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source = ( DESCRIPTION = ( ADDRESS = ( PROTOCOL = TCP ) ( HOST = localhost) ( PORT = 1521)) (CONNECT_DATA=( SERVER= DEDICATED ) (SERVICE_NAME= XE))); User id= train; password= project;";
           
            OracleConnection conn = new OracleConnection(s);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select  * from veg ";
             
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable tab = new DataTable();
            tab.Load(dr);

            dataGridView1.DataSource = tab;



        }
    }
}

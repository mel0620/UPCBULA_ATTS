using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UPCBulaATS
{
    public partial class frmViewAttendance : Form
    {
        public frmViewAttendance()
        {
            InitializeComponent();
        }

        DataTable table;

        private void att()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attend_view;", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mens()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attend_view WHERE DEPARTMENT = 'Men';", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void la()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attend_view WHERE DEPARTMENT = 'LA';", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void youth()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attend_view WHERE DEPARTMENT = 'Youth';", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void chil()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attend_view WHERE DEPARTMENT = 'Children';", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmViewAttendance_Load(object sender, EventArgs e)
        {
            att();
        }

        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(table);
            DV.RowFilter = string.Format("NAME LIKE '%{0}%'", txtSear.Text);
            dataGridView1.DataSource = DV;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            att();
        }

        private void rbtnMens_CheckedChanged(object sender, EventArgs e)
        {
            mens();
        }

        private void rbtnLA_CheckedChanged(object sender, EventArgs e)
        {
            la();
        }

        private void rbtnYouth_CheckedChanged(object sender, EventArgs e)
        {
            youth();
        }

        private void rbtnChild_CheckedChanged(object sender, EventArgs e)
        {
            chil();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                MySqlConnection connect = new MySqlConnection(Constring);
                string command = "SELECT * FROM upcbuladb.attend_view where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

                MySqlCommand commExec = new MySqlCommand(command, connect);

                table = new DataTable();

                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = commExec;
                adapt.Fill(table);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
                adapt.Update(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            att();
        }

        private void BtnReload_Click_1(object sender, EventArgs e)
        {
            att();
        }
    }
}

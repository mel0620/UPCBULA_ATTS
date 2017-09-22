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
    public partial class frmAtten : Form
    {
        public frmAtten()
        {
            InitializeComponent();
        }

        MySqlConn connect = new MySqlConn();

        private void btnSave_Click(object sender, EventArgs e)
        {
 
            if (cmbEvent.Text == "")
            {
                MessageBox.Show("Please complete the information.");
            }
            else
            {

                string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
                string Query = "INSERT INTO attendance (a_date, a_time, fname, lname, department, event) VALUES ('" + this.dtpDate.Text + "','" + this.dtpTime.Text + "','" + this.txtFName.Text + "','" + this.txtLName.Text + "','" + this.txtDept.Text + "','" + this.cmbEvent.Text + "');";
                //string Query1 = "INSERT INTO attendance (Department) VALUES ('" + dept.ToString() + "');";
                MySqlConnection mycon = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(Query, mycon);
                //MySqlCommand cmd1 = new MySqlCommand(Query1, mycon);
                MySqlDataReader reader;

                //cmd.Parameters.Add(new MySqlParameter("Department =", dept.ToString()));

                try
                {

                    mycon.Open();

                    reader = cmd.ExecuteReader();

                    if (MessageBox.Show("Do you want to save now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show("Attendance Saved.\nGodbless you!");
                    }
                    txtID.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtDept.Text = "";
                    cmbEvent.Text = "";
                    dtpDate.Text = "";

                    mycon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSaveVisitor.Enabled = true;
            txtID.Enabled = false;
            txtID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtDept.Text = "";
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtDept.Enabled = true;
            cmbEvent.Text = "";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            try
            {

                if (txtID.Text == "")
                {
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtDept.Text = "";
                    cmbEvent.Text = "";

                }

                connect.Conn();
                string commandStr = "SELECT * FROM members WHERE `m_id` = '" + txtID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(commandStr, connect.myconnect);


                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    this.txtFName.Text = reader.GetString("fname");
                    this.txtLName.Text = reader.GetString("lname");
                    this.txtDept.Text = reader.GetString("department");

                    
                    txtFName.Enabled = false;
                    txtLName.Enabled = false;
                    txtDept.Enabled = false;
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnSaveVisitor_Click(object sender, EventArgs e)
        {
            if (cmbEvent.Text == "")
            {
                MessageBox.Show("Please complete the information.");
            }
            else
            {
                string visitor = "Visitor";
                string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
                string Query = "INSERT INTO attendance (a_date, a_time, fname, lname, department, event, visitor) VALUES ('" + this.dtpDate.Text + "','" + this.dtpTime.Text + "','" + this.txtFName.Text + "','" + this.txtLName.Text + "','" + this.txtDept.Text + "','" + this.cmbEvent.Text + "','" + visitor + "');";
                //string Query1 = "INSERT INTO attendance (Department) VALUES ('" + dept.ToString() + "');";
                MySqlConnection mycon = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(Query, mycon);
                //MySqlCommand cmd1 = new MySqlCommand(Query1, mycon);
                MySqlDataReader reader;

                //cmd.Parameters.Add(new MySqlParameter("Department =", dept.ToString()));

                try
                {

                    mycon.Open();

                    reader = cmd.ExecuteReader();

                    if (MessageBox.Show("Do you want to save now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show("Attendance Saved.\nGodbless you!");
                    }
                    txtID.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtDept.Text = "";
                    cmbEvent.Text = "";
                    dtpDate.Text = "";

                    mycon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            btnSaveVisitor.Enabled = false;
            btnSave.Enabled = true;
            txtID.Enabled = true;
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtDept.Enabled = false;
            cmbEvent.Text = "";

        }

        /*private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                btnSear_Click((object)sender, (EventArgs)e);
                SendKeys.Send("{TAB}");
                e.Handled = true;//set to false if you need that textbox gets enter key
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSear_Click((object)sender, (EventArgs)e);
            }
        }*/
        }
    }


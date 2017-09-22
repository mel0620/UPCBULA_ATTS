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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=cuneta";
                MySqlConnection myconn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM upcbuladb.user WHERE Username = '" + this.txtUser.Text + "' AND Password='" + this.txtPass.Text + "';", myconn);

                MySqlDataReader myReader;
                myconn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    this.Hide();
                    //new frmRecTithes().Show();
                    new frmMembersInfo().Show();
                }

                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password ... Access Denied");
                }

                else if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Please Complete the information!");
                }

                else
                    MessageBox.Show("Username and Password is incorrect!\nPlease try again!");
                myconn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


            try
            {
                if (txtUser.Text == "username" || string.IsNullOrEmpty(txtUser.Text) || txtPass.Text == "password" || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Please input a valid username and password.");
                }

                else
                {
                    string MyConn = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection myconn = new MySqlConnection(MyConn);
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataReader dr;

                    cmd = new MySqlCommand(); // check

                    string query = "SELECT * FROM upcbuladb.user WHERE username=@username AND password=@password;";
                    myconn.Open();
                    cmd.Connection = myconn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        if (dr.HasRows == false)
                        {
                            MessageBox.Show("Incorrect username or password.");
                        }
                        else
                        {
                            string usertype = dr["usertype"].ToString();

                            if (usertype == "lasec")
                            {
                                this.Dispose();
                                new frmMembersInfo().Show();
                                myconn.Close();

                            }

                            else if (usertype == "youthpres")
                            {
                                this.Dispose();
                                //new frmYouth().Show();
                                new frmYouthMenu().Show();
                                myconn.Close();
                            }

                            /*else if (usertype == "Cashier")
                            {
                                frmCashier frm = new frmCashier();
                                frm.MdiParent = this.ParentForm; //this refers to f1's parent, the MainForm
                                this.Dispose();
                                frm.Show();
                                frm.txtuser.Text = dr.GetString("fname");
                                frm.lblUT.Text = dr.GetString("usertype");
                                frm.Show();
                                myconn.Close();
                            }*/
                            else
                            {
                                MessageBox.Show("Incorrect username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
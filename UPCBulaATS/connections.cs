using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UPCBulaATS
{
    class connections
    {
        MySqlConn connect = new MySqlConn();

        public void add()
        {

            string dob = DateTime.Parse(frmMembersInfo.dob).ToString("yyyy/MM/dd ");
            string datebap = DateTime.Parse(frmMembersInfo.datebaptized).ToString("yyyy/MM/dd ");

            try
            {
                connect.Conn();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO members (m_id, fname, mname, lname, dob, datebaptized, address, department, ministry) VALUES ('" + frmMembersInfo.m_id + "','" + frmMembersInfo.fname + "','" + frmMembersInfo.mname + "','" + frmMembersInfo.lname + "','" + dob + "','" + datebap + "','" + frmMembersInfo.address + "','" + frmMembersInfo.department + "','" + frmMembersInfo.ministry + "')", connect.myconnect);

                //cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.myconnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful." + ex.Message);
            }

        }

        public void update()
        {
            try
            {
                connect.Conn();
                MySqlCommand cmd = new MySqlCommand("UPDATE members SET m_id  = '" + frmMembersInfo.m_id + "', fname = '" + frmMembersInfo.fname + "', mname = '" + frmMembersInfo.mname + "', lname = '" + frmMembersInfo.lname + "', dob = '" + frmMembersInfo.dob + "', datebaptized ='" + frmMembersInfo.datebaptized + "', address ='" + frmMembersInfo.address + "' , department ='" + frmMembersInfo.department + "', ministry = '" + frmMembersInfo.ministry + "' WHERE fname = '" + frmMembersInfo.fname + "' ", connect.myconnect);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.myconnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful." + ex.Message);
            }

        }
    }
}

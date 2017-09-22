using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace UPCBulaATS
{
    class MySqlConn
    {
        string myconnection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
        public MySqlConnection myconnect;

        public void Conn()
        {

            try
            {

                myconnect = new MySqlConnection(myconnection);
                myconnect.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connecting to DB : " + ex.Message);
            }

        }
    }
}

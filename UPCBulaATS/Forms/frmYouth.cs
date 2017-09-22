using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UPCBulaATS
{
    public partial class frmYouth : Form
    {
        public frmYouth()
        {
            InitializeComponent();
        }

        MySqlConn connect = new MySqlConn();
        DataTable table;

        private void total()
        {

            double item = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                item += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
            }

            lblTotal.Text = item.ToString("#,##0.##");
        }

        private void youth()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youth_view;", mycon);

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

        private void clear()
        {

            dateTimePicker1.Text = "";
            cmbChurchAdd.Text = "";
            txtName.Text = "";
            txtAmount.Text = "";
            cmbDesc.Text = "";

        }

        private void sanramon()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view where CHURCH_ADDRESS = 'San Ramon'", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView2.DataSource = source;
                adap.Update(table);
                total();
                mycon.Close();

                
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bagumbayan()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view where CHURCH_ADDRESS = 'Bagumbayan'", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView2.DataSource = source;
                adap.Update(table);
                total();
                mycon.Close();


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void casugad()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view where CHURCH_ADDRESS = 'Casugad'", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView2.DataSource = source;
                adap.Update(table);
                total();
                mycon.Close();


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void youthfund()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view;", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView2.DataSource = source;
                adap.Update(table);
                total();
                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmYouth_Load(object sender, EventArgs e)
        {
            youth();
            youthfund();
        }

        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(table);
                DV.RowFilter = string.Format("NAME LIKE '%{0}%'", txtSear.Text);
                dataGridView1.DataSource = DV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Name = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtName.Text = Name;

            }
        }

        private void txtSear_MouseClick(object sender, MouseEventArgs e)
        {
            youth();
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(table);
                DV.RowFilter = string.Format("NAME LIKE '%{0}%'", txtSearch2.Text);
                dataGridView2.DataSource = DV;
                total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch2_MouseClick(object sender, MouseEventArgs e)
        {
            //youthfund();
            total();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAmount.Text == "" || cmbChurchAdd.Text == "" || cmbDesc.Text == "")
            {
                MessageBox.Show("You must input a value.");
            }
            else
            {
                try
                {

                    connect.Conn();
                    string commandStr = "INSERT INTO youthfunds (date, church_address, name, amount, description) VALUES ('" + this.dateTimePicker1.Text + "','" + this.cmbChurchAdd.Text + "','" + this.txtName.Text + "','" + this.txtAmount.Text + "','" + this.cmbDesc.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(commandStr, connect.myconnect);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (MessageBox.Show("Do you really want to Add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show("Fund Saved");

                        youthfund();
                        total();
                        clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rbtnSanRamon_CheckedChanged(object sender, EventArgs e)
        {
            sanramon();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            youthfund();
        }

        private void rbtnBabumbayan_CheckedChanged(object sender, EventArgs e)
        {
            bagumbayan();
        }

        private void rbtnCasugad_CheckedChanged(object sender, EventArgs e)
        {
            casugad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                MySqlConnection connect = new MySqlConnection(Constring);
                string command = "SELECT * FROM upcbuladb.youthfunds_view where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

                MySqlCommand commExec = new MySqlCommand(command, connect);

                table = new DataTable();

                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = commExec;
                adapt.Fill(table);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = table;
                dataGridView2.DataSource = bSource;
                adapt.Update(table);
                total();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchDesc_TextChanged(object sender, EventArgs e)
        {
            youthfund();
            try
            {
                DataView DV = new DataView(table);
                DV.RowFilter = string.Format("DESCRIPTION LIKE '%{0}%'", txtSearchDesc.Text);
                dataGridView2.DataSource = DV;
                total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbtnSanRamon.Checked == true)
            {
                string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
                MySqlConnection mycon = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view WHERE CHURCH_ADDRESS = 'San Ramon' AND DESCRIPTION = '" + txtSearchDesc.Text + "'", mycon);

                try
                {
                    mycon.Open();

                    MySqlDataAdapter adap = new MySqlDataAdapter();
                    adap.SelectCommand = cmd;
                    table = new DataTable();
                    adap.Fill(table);
                    BindingSource source = new BindingSource();
                    source.DataSource = table;
                    dataGridView2.DataSource = source;
                    adap.Update(table);
                    total();
                    mycon.Close();


                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            else if (rbtnBabumbayan.Checked == true)
            {
                string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
                MySqlConnection mycon = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view WHERE CHURCH_ADDRESS = 'Bagumbayan' AND DESCRIPTION = '" + txtSearchDesc.Text + "'", mycon);

                try
                {
                    mycon.Open();

                    MySqlDataAdapter adap = new MySqlDataAdapter();
                    adap.SelectCommand = cmd;
                    table = new DataTable();
                    adap.Fill(table);
                    BindingSource source = new BindingSource();
                    source.DataSource = table;
                    dataGridView2.DataSource = source;
                    adap.Update(table);
                    total();
                    mycon.Close();


                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (rbtnCasugad.Checked == true)
            {
                string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
                MySqlConnection mycon = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view WHERE CHURCH_ADDRESS = 'Casugad' AND DESCRIPTION = '" + txtSearchDesc.Text + "'", mycon);

                try
                {
                    mycon.Open();

                    MySqlDataAdapter adap = new MySqlDataAdapter();
                    adap.SelectCommand = cmd;
                    table = new DataTable();
                    adap.Fill(table);
                    BindingSource source = new BindingSource();
                    source.DataSource = table;
                    dataGridView2.DataSource = source;
                    adap.Update(table);
                    total();
                    mycon.Close();


                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM youthfunds_view where DESCRIPTION = '" + txtSearchDesc.Text+ "'", mycon);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView2.DataSource = source;
                adap.Update(table);
                total();
                mycon.Close();


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            Document doc = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("YouthFunds.pdf", FileMode.Create));
            doc.Open();
            //FontFactory.RegisterDirectories();
            //Font fontNormal = new Font(FontFactory.GetFont("Arial", 12, Font.NORMAL))
            /*iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("C:\\Users\\mike\\Documents\\Visual Studio 2010\\Projects\\SARFCTPSPROJECT\\SARFCTPSPROJECT\\bin\\Debug\\sarfc.PNG");
            PNG.ScalePercent(50f);
            PNG.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            doc.Add(PNG);*/

            Paragraph para = new Paragraph("YOUTH FUNDS' RECORD\n\n\n\n");

            para.Alignment = Element.ALIGN_CENTER;
            doc.Add(para);


            PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);
            iTextSharp.text.Font fontTable = FontFactory.GetFont("Calibri", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            table.DefaultCell.Padding = 5;
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.WidthPercentage = 100;
            //table.SpacingBefore = 45f;
            //table.TotalWidth = 216f;
            table.DefaultCell.Phrase = new Phrase() { Font = fontTable };

            table.DefaultCell.BorderWidth = 0;


            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView2.Columns.Count; k++)
                {
                    if (dataGridView2[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            List info = new List(List.UNORDERED);
            info.SetListSymbol("");
            info.Add("\nTotal Amount:    " + lblTotal.Text + "\n");
            //info.Add("\n                " + label23.Text + "  " + lbltth.Text);
            doc.Add(info);

            doc.Close();
            //System.Diagnostics.Process.Start("C:\\Users\\mike\\Documents\\Visual Studio 2010\\Projects\\SARFCTPSPROJECT\\SARFCTPSPROJECT\\bin\\Debug\\profile.pdf");
            System.Diagnostics.Process.Start("YouthFunds.pdf");
        }
    }
}

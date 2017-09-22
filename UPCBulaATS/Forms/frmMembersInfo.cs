using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;


namespace UPCBulaATS
{
    public partial class frmMembersInfo : Form
    {
        public frmMembersInfo()
        {
            InitializeComponent();
        }

        MySqlConn connect = new MySqlConn();
        DataTable table;

        public static string m_id = "";
        public static string fname = "";
        public static string mname = "";
        public static string lname = "";
        public static string dob = "";
        public static string datebaptized = "";
        public static string address = "";
        public static string department = "";
        public static string ministry = "";

        private void total()
        {
   
            double item = 0;
            double tth = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                item += Convert.ToDouble(dataGridView2.Rows[i].Cells[11].Value);
            }

            tithes_total.Text = item.ToString("#,##0.##");

            tth = item * 0.10;

            lbltth.Text = tth.ToString("#,##0.##");

            double item2 = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                item2 += Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
            }

            deptTotals.Text = item2.ToString("#,##0.##");

        }

        private void textboxes()
        { 
        
            m_id = txtm_id.Text;
            fname = txtfname.Text;
            mname = txtmname.Text;
            lname = txtlname.Text;
            dob = dtpDOB.Text;
            datebaptized = dtpDateBaptized.Text;
            address = cmbAdd.Text;
            department = txtdept.Text;
            ministry = txtmin.Text;
        
        }

        private void enable()
        {
            txtm_id.Enabled = true;
            txtfname.Enabled = true;
            txtmname.Enabled = true;
            txtlname.Enabled = true;
            txtdept.Enabled = true;
            txtmin.Enabled = true;
            cmbAdd.Enabled = true;
            txtFather.Enabled = true;
            txtMother.Enabled = true;
        }

        private void reset()
        {
            txtm_id.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtdept.Text = "";
            txtmin.Text = "";
            cmbAdd.Text = "";
            lblDBAGE.Text = "";
            lblDOBAGE.Text = "";
            dtpDOB.Text = "";
            dtpDateBaptized.Text = "";
            txtMother.Text = "";
            txtFather.Text = "";
        }

        private void reset2()
        {
            dtpTithes.Text = "";
            txtmid.Text = "";
            txtname.Text = "";
            txtTithes.Text = "";
            txtOffer.Text = "";
            txtMPFC.Text = "";
            txtSunSch.Text = "";
            txtEvang.Text = "";
            txtRadio.Text = "";
            txtLot.Text = "";
            txtTotal.Text = "00.00";
        }

        private void tith()
        {

            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tithes_view;", mycon);

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


               /* DataSet ds = new DataSet("New_Dataset");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                adap.Fill(table);
                ds.Tables.Add(table);
                ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile.xlsx", ds);*/


                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void hor()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM HOR;", mycon);

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

                lbltotals.Text = "Total HOR:";


                double item = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    item += Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
                }

                deptTotals.Text = item.ToString("#,##0.##");

                total();

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mpfc()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM MPFC;", mycon);

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

                lbltotals.Text = "Total MPFC:";
                double item = 0;
               
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    item += Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
                }

                deptTotals.Text = item.ToString("#,##0.##");

                total();

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void sfc()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM SFC;", mycon);

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

                lbltotals.Text = "Total SFC:";
                double totsfc = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    totsfc += Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
                }

                deptTotals.Text = totsfc.ToString("#,##0.##");


                total();

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void soc()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM SOC;", mycon);

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

                lbltotals.Text = "Total SOC:";
                double item = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    item += Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
                }

                deptTotals.Text = item.ToString("#,##0.##");
                total();

                mycon.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void member()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mem_view;", mycon);


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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mem_view WHERE DEPARTMENT = 'MEN';", mycon);

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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mem_view WHERE DEPARTMENT = 'LA';", mycon);

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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mem_view WHERE DEPARTMENT = 'Youth';", mycon);

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

        private void children()
        {
            string connection = "server=localhost; database=upcbuladb;uid=root;pwd=cuneta";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM mem_view WHERE DEPARTMENT = 'Children';", mycon);

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

        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(table);
                DV.RowFilter = string.Format("FIRSTNAME LIKE '%{0}%'", txtSear.Text);
                dataGridView1.DataSource = DV;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMembersInfo_Load(object sender, EventArgs e)
        {
            //lbltotals.Text = "";
            //label24.Text = "";
            deptTotals.Text = "";

            tith();
            member();
            total();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnISave.Enabled = false;
                btnUpdate.Enabled = true;
                enable();
                txtm_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtfname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtmname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtlname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtpDOB.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtpDateBaptized.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmbAdd.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtdept.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtmin.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //new frmRecTithes().Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enable();
            reset();
            btnUpdate.Enabled = false;
            btnISave.Enabled = true;

        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            member();
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
            children();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - dtpDOB.Value.Year;

            if (dtpDOB.Value.AddYears(years) > DateTime.Now) years--;

            lblDOBAGE.Text = "" + years;
        }

        private void dtpDateBaptized_ValueChanged(object sender, EventArgs e)
        {

            int years = DateTime.Now.Year - dtpDateBaptized.Value.Year;

            if (dtpDateBaptized.Value.AddYears(years) > DateTime.Now) years--;

            lblDBAGE.Text = "" + years;
        }

        private void btnISave_Click(object sender, EventArgs e)
        {
            if (this.txtfname.Text == "" || this.txtmname.Text == "" || this.txtlname.Text == "" || this.txtdept.Text == "" || this.txtmin.Text == "")
            {
                MessageBox.Show("Please Complete the Information!");
            }

            else
            {
                textboxes();

                if (MessageBox.Show("Do you really want to Add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    connections insert = new connections();
                    insert.add();
                }

                reset();
                member();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            textboxes();

            if (MessageBox.Show("Do you really want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                connections update = new connections();
                update.update();
            }

            member();
            btnISave.Enabled = false;
            reset();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtTithes.Text == "")
            {
                MessageBox.Show("You must input an amount.");
            }
            else
            {
                try
                {
                    double n1 = double.Parse(txtTithes.Text);
                    double n2 = double.Parse(txtOffer.Text);
                    double n4 = double.Parse(txtMPFC.Text);
                    double n3 = double.Parse(txtSunSch.Text);
                    double n5 = double.Parse(txtEvang.Text);
                    double n6 = double.Parse(txtRadio.Text);
                    double n7 = double.Parse(txtLot.Text);
                    double total;

                    total = n1 + n2 + n3 + n4 + n5 + n6 + n7;

                    txtTotal.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void txtmid_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if(txtmid.Text == "")
                {
                    txtname.Text = "";
                    dept.Text = "";
                }
                
                connect.Conn();
                string commandStr = "SELECT * FROM name_view WHERE `m_id` = '" + txtmid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(commandStr, connect.myconnect);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    this.txtname.Text = reader.GetString("name");
                    this.dept.Text = reader.GetString("department");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void txtmid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btntSave_Click(object sender, EventArgs e)
        {
            if (txtmid.Text == "" || txtname.Text == "" || txtTithes.Text == "" || txtOffer.Text == "" || txtSunSch.Text == "" || txtMPFC.Text == "" || txtRadio.Text == "" || txtEvang.Text == "" || txtLot.Text == "")
            {
                MessageBox.Show("You must input a value.");
            }
            else
            {
              
                try
                {

                    connect.Conn();

                    string commandStr = "INSERT INTO tithes (t_date, m_id, name, department, tithes, offering, mpfchorsfcsoc, sundayschool, evangelism, radio, lot, total) VALUES ('" + this.dtpTithes.Text + "','" + this.txtmid.Text + "','" + this.txtname.Text + "','" + this.dept.Text + "','" + this.txtTithes.Text + "','" + this.txtOffer.Text + "','" + this.txtMPFC.Text + "','" 
	                                        + this.txtSunSch.Text + "','" + this.txtEvang.Text + "','" + this.txtRadio.Text + "','" 
	                                        + this.txtLot.Text + "','" + this.txtTotal.Text + "');";
                    
                    MySqlCommand cmd = new MySqlCommand(commandStr, connect.myconnect);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (MessageBox.Show("Do you really want to Add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MessageBox.Show("Saved");

                        tith();
                        reset2();
                        total();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtTithes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.')) 
            {
                e.Handled = true;
            }
        }

        private void txtOffer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtSunSch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtMPFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtEvang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtMusic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            total();
            tith();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            Document doc = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Tithes.pdf", FileMode.Create));
            doc.Open();
            //FontFactory.RegisterDirectories();
            //Font fontNormal = new Font(FontFactory.GetFont("Arial", 12, Font.NORMAL))
            /*iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("C:\\Users\\mike\\Documents\\Visual Studio 2010\\Projects\\SARFCTPSPROJECT\\SARFCTPSPROJECT\\bin\\Debug\\sarfc.PNG");
            PNG.ScalePercent(50f);
            PNG.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            doc.Add(PNG);*/

            Paragraph para = new Paragraph("TITHES RECORD\n\n\n\n");
            
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
            //info.Add("\n                " + lbltotals.Text + "  " + deptTotals.Text + "\n");
            //info.Add("\n                " + label24.Text + "  " + lblmhss.Text);
            info.Add("\n                Total Amount:    " + tithes_total.Text + "\n");
            info.Add("\n                " + label23.Text + "  " + lbltth.Text);
            doc.Add(info);

            doc.Close();
            //System.Diagnostics.Process.Start("C:\\Users\\mike\\Documents\\Visual Studio 2010\\Projects\\SARFCTPSPROJECT\\SARFCTPSPROJECT\\bin\\Debug\\profile.pdf");
            System.Diagnostics.Process.Start("Tithes.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                try
                {
                    string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection connect = new MySqlConnection(Constring);
                    string command = "SELECT * FROM upcbuladb.sfc where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

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
            else if (radioButton2.Checked == true)
            {
                try
                {
                    string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection connect = new MySqlConnection(Constring);
                    string command = "SELECT * FROM upcbuladb.mpfc where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

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

            else if (rbtnHOR.Checked == true)
            {
                try
                {
                    string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection connect = new MySqlConnection(Constring);
                    string command = "SELECT * FROM upcbuladb.hor where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

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

            else if (radioButton4.Checked == true)
            {
                try
                {
                    string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection connect = new MySqlConnection(Constring);
                    string command = "SELECT * FROM upcbuladb.soc where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

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
            else
                try
                {
                    string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                    MySqlConnection connect = new MySqlConnection(Constring);
                    string command = "SELECT * FROM upcbuladb.tithes_view where DATE between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset2();
        }

        private void rbtnHOR_CheckedChanged(object sender, EventArgs e)
        {
            hor();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbltotals.Text = "Total:";
            //label24.Text = "";
            deptTotals.Text = "";

            tith();
            total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mpfc();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sfc();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            soc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Constring = "datasource=localhost;port=3306;username=root;password=cuneta";
                MySqlConnection connect = new MySqlConnection(Constring);
                string command = "SELECT * FROM upcbuladb.mem_view where FIRSTNAME = '" + txtSear.Text + "'";

                MySqlCommand commExec = new MySqlCommand(command, connect);

                table = new DataTable();

                MySqlDataAdapter adapt = new MySqlDataAdapter();
                adapt.SelectCommand = commExec;
                adapt.Fill(table);


                BindingSource bSource = new BindingSource();

                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
                adapt.Update(table);

                total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button3.PerformClick();
                txtSear.Text = "";
            }
        }

        private void txtSearch2_TextChanged_1(object sender, EventArgs e)
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

        private void btnExport_Click(object sender, EventArgs e)
        {
                saveFileDialog1.InitialDirectory = "C:";
                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel Files(2010)|*.xlsx";

                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application export = new Microsoft.Office.Interop.Excel.Application();
                    export.Application.Workbooks.Add(Type.Missing);

                    export.Columns.ColumnWidth = 20;

                    for (int i = 0; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        export.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            export.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    export.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    export.ActiveWorkbook.Saved = true;
                    export.Quit();
                }
        }

    }
}

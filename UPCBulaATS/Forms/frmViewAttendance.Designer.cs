namespace UPCBulaATS
{
    partial class frmViewAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSear = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnChild = new System.Windows.Forms.RadioButton();
            this.rbtnYouth = new System.Windows.Forms.RadioButton();
            this.rbtnLA = new System.Windows.Forms.RadioButton();
            this.rbtnMens = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.BtnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Name:";
            // 
            // txtSear
            // 
            this.txtSear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSear.Location = new System.Drawing.Point(703, 75);
            this.txtSear.Multiline = true;
            this.txtSear.Name = "txtSear";
            this.txtSear.Size = new System.Drawing.Size(163, 29);
            this.txtSear.TabIndex = 0;
            this.txtSear.TextChanged += new System.EventHandler(this.txtSear_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 354);
            this.dataGridView1.TabIndex = 5;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(13, 80);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(56, 24);
            this.rbtnAll.TabIndex = 19;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "ALL";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnChild
            // 
            this.rbtnChild.AutoSize = true;
            this.rbtnChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChild.ForeColor = System.Drawing.Color.White;
            this.rbtnChild.Location = new System.Drawing.Point(285, 80);
            this.rbtnChild.Name = "rbtnChild";
            this.rbtnChild.Size = new System.Drawing.Size(110, 24);
            this.rbtnChild.TabIndex = 18;
            this.rbtnChild.TabStop = true;
            this.rbtnChild.Text = "CHILDREN";
            this.rbtnChild.UseVisualStyleBackColor = true;
            this.rbtnChild.CheckedChanged += new System.EventHandler(this.rbtnChild_CheckedChanged);
            // 
            // rbtnYouth
            // 
            this.rbtnYouth.AutoSize = true;
            this.rbtnYouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYouth.ForeColor = System.Drawing.Color.White;
            this.rbtnYouth.Location = new System.Drawing.Point(196, 80);
            this.rbtnYouth.Name = "rbtnYouth";
            this.rbtnYouth.Size = new System.Drawing.Size(83, 24);
            this.rbtnYouth.TabIndex = 17;
            this.rbtnYouth.TabStop = true;
            this.rbtnYouth.Text = "YOUTH";
            this.rbtnYouth.UseVisualStyleBackColor = true;
            this.rbtnYouth.CheckedChanged += new System.EventHandler(this.rbtnYouth_CheckedChanged);
            // 
            // rbtnLA
            // 
            this.rbtnLA.AutoSize = true;
            this.rbtnLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLA.ForeColor = System.Drawing.Color.White;
            this.rbtnLA.Location = new System.Drawing.Point(143, 80);
            this.rbtnLA.Name = "rbtnLA";
            this.rbtnLA.Size = new System.Drawing.Size(49, 24);
            this.rbtnLA.TabIndex = 16;
            this.rbtnLA.TabStop = true;
            this.rbtnLA.Text = "LM";
            this.rbtnLA.UseVisualStyleBackColor = true;
            this.rbtnLA.CheckedChanged += new System.EventHandler(this.rbtnLA_CheckedChanged);
            // 
            // rbtnMens
            // 
            this.rbtnMens.AutoSize = true;
            this.rbtnMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMens.ForeColor = System.Drawing.Color.White;
            this.rbtnMens.Location = new System.Drawing.Point(75, 80);
            this.rbtnMens.Name = "rbtnMens";
            this.rbtnMens.Size = new System.Drawing.Size(62, 24);
            this.rbtnMens.TabIndex = 15;
            this.rbtnMens.TabStop = true;
            this.rbtnMens.Text = "MEN";
            this.rbtnMens.UseVisualStyleBackColor = true;
            this.rbtnMens.CheckedChanged += new System.EventHandler(this.rbtnMens_CheckedChanged);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(207, 473);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 20);
            this.label27.TabIndex = 87;
            this.label27.Text = "To:";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(16, 474);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 20);
            this.label26.TabIndex = 85;
            this.label26.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTo.CustomFormat = "yyyy/MM/dd";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(244, 470);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(129, 29);
            this.dtpTo.TabIndex = 86;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(379, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 28);
            this.button2.TabIndex = 84;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(72, 470);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(129, 29);
            this.dtpFrom.TabIndex = 83;
            // 
            // BtnReload
            // 
            this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReload.BackColor = System.Drawing.Color.Indigo;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.FlatAppearance.BorderSize = 0;
            this.BtnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReload.ForeColor = System.Drawing.Color.White;
            this.BtnReload.Location = new System.Drawing.Point(452, 470);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(67, 28);
            this.BtnReload.TabIndex = 88;
            this.BtnReload.Text = "RELOAD";
            this.BtnReload.UseVisualStyleBackColor = false;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click_1);
            // 
            // frmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(878, 508);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.rbtnChild);
            this.Controls.Add(this.rbtnYouth);
            this.Controls.Add(this.rbtnLA);
            this.Controls.Add(this.rbtnMens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmViewAttendance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Attendance";
            this.Load += new System.EventHandler(this.frmViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnChild;
        private System.Windows.Forms.RadioButton rbtnYouth;
        private System.Windows.Forms.RadioButton rbtnLA;
        private System.Windows.Forms.RadioButton rbtnMens;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button BtnReload;
    }
}
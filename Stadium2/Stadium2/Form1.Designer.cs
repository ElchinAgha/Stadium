namespace Stadium2
{
    partial class Form1
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CmbStadiums = new System.Windows.Forms.ComboBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTime = new System.Windows.Forms.ComboBox();
            this.CkbSubcribe = new System.Windows.Forms.CheckBox();
            this.CkbSingleUse = new System.Windows.Forms.CheckBox();
            this.CmbWeeks = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvStadium = new System.Windows.Forms.DataGridView();
            this.LblError = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStadium)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(20, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Ad";
            this.LblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(15, 40);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(135, 20);
            this.TxtName.TabIndex = 0;
            // 
            // CmbStadiums
            // 
            this.CmbStadiums.FormattingEnabled = true;
            this.CmbStadiums.Location = new System.Drawing.Point(15, 140);
            this.CmbStadiums.Name = "CmbStadiums";
            this.CmbStadiums.Size = new System.Drawing.Size(135, 21);
            this.CmbStadiums.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(15, 89);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(135, 20);
            this.TxtSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stadion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Başlama vaxtı";
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.DtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStartDate.Location = new System.Drawing.Point(15, 197);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(135, 20);
            this.DtpStartDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Müddət";
            // 
            // CmbTime
            // 
            this.CmbTime.FormattingEnabled = true;
            this.CmbTime.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.CmbTime.Location = new System.Drawing.Point(15, 249);
            this.CmbTime.Name = "CmbTime";
            this.CmbTime.Size = new System.Drawing.Size(135, 21);
            this.CmbTime.TabIndex = 4;
            // 
            // CkbSubcribe
            // 
            this.CkbSubcribe.AutoSize = true;
            this.CkbSubcribe.Location = new System.Drawing.Point(15, 294);
            this.CkbSubcribe.Name = "CkbSubcribe";
            this.CkbSubcribe.Size = new System.Drawing.Size(57, 17);
            this.CkbSubcribe.TabIndex = 5;
            this.CkbSubcribe.Text = "Abune";
            this.CkbSubcribe.UseVisualStyleBackColor = true;
            this.CkbSubcribe.CheckedChanged += new System.EventHandler(this.CkbSubcribe_CheckedChanged);
            // 
            // CkbSingleUse
            // 
            this.CkbSingleUse.AutoSize = true;
            this.CkbSingleUse.Location = new System.Drawing.Point(15, 317);
            this.CkbSingleUse.Name = "CkbSingleUse";
            this.CkbSingleUse.Size = new System.Drawing.Size(69, 17);
            this.CkbSingleUse.TabIndex = 7;
            this.CkbSingleUse.Text = "Birdəfəlik";
            this.CkbSingleUse.UseVisualStyleBackColor = true;
            this.CkbSingleUse.CheckedChanged += new System.EventHandler(this.CkbSingleUse_CheckedChanged);
            // 
            // CmbWeeks
            // 
            this.CmbWeeks.Enabled = false;
            this.CmbWeeks.FormattingEnabled = true;
            this.CmbWeeks.Items.AddRange(new object[] {
            "4",
            "8",
            "12",
            "36",
            "52"});
            this.CmbWeeks.Location = new System.Drawing.Point(78, 294);
            this.CmbWeeks.Name = "CmbWeeks";
            this.CmbWeeks.Size = new System.Drawing.Size(72, 21);
            this.CmbWeeks.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvStadium
            // 
            this.DgvStadium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStadium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvStadium.Location = new System.Drawing.Point(186, 40);
            this.DgvStadium.Name = "DgvStadium";
            this.DgvStadium.Size = new System.Drawing.Size(792, 294);
            this.DgvStadium.TabIndex = 14;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(12, 369);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Başlama vaxtı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Müddət";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bitmə vaxtı";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stadion";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Növ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Qiymət";
            this.Column9.Name = "Column9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 473);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.DgvStadium);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbWeeks);
            this.Controls.Add(this.CkbSingleUse);
            this.Controls.Add(this.CkbSubcribe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTime);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbStadiums);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStadium)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CmbStadiums;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTime;
        private System.Windows.Forms.CheckBox CkbSubcribe;
        private System.Windows.Forms.CheckBox CkbSingleUse;
        private System.Windows.Forms.ComboBox CmbWeeks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvStadium;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}


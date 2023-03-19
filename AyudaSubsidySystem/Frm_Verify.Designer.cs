
namespace AyudaSubsidySystem
{
    partial class Frm_Verify
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.text_Contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Sex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_MonthlyIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Occupation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Birthdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Middlename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ayudaDataSet = new AyudaSubsidySystem.AyudaDataSet();
            this.verificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationTableAdapter = new AyudaSubsidySystem.AyudaDataSetTableAdapters.VerificationTableAdapter();
            this.idnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.householdnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verificationstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayudaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(840, 15);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(69, 30);
            this.Btn_Search.TabIndex = 48;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // text_Search
            // 
            this.text_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Search.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Search.Location = new System.Drawing.Point(673, 15);
            this.text_Search.Multiline = true;
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(168, 30);
            this.text_Search.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 56);
            this.label1.TabIndex = 44;
            this.label1.Text = "PROCESS FOR VERIFICATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.Btn_Update);
            this.panel2.Controls.Add(this.Btn_Refresh);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Controls.Add(this.text_Contact);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.text_Sex);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.text_Address);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.text_MonthlyIncome);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_Occupation);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.text_Birthdate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.text_Middlename);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.text_Firstname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.text_Lastname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 374);
            this.panel2.TabIndex = 45;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Update.Location = new System.Drawing.Point(628, 57);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(118, 31);
            this.Btn_Update.TabIndex = 57;
            this.Btn_Update.Text = "UPDATE";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Refresh.Location = new System.Drawing.Point(628, 22);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(118, 31);
            this.Btn_Refresh.TabIndex = 56;
            this.Btn_Refresh.Text = "REFRESH";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Delete.Location = new System.Drawing.Point(628, 94);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(118, 31);
            this.Btn_Delete.TabIndex = 55;
            this.Btn_Delete.Text = "DELETE";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // text_Contact
            // 
            this.text_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Contact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Contact.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Contact.Location = new System.Drawing.Point(444, 71);
            this.text_Contact.Multiline = true;
            this.text_Contact.Name = "text_Contact";
            this.text_Contact.Size = new System.Drawing.Size(167, 20);
            this.text_Contact.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGreen;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(372, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Contact";
            // 
            // text_Sex
            // 
            this.text_Sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Sex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Sex.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Sex.Location = new System.Drawing.Point(444, 46);
            this.text_Sex.Multiline = true;
            this.text_Sex.Name = "text_Sex";
            this.text_Sex.Size = new System.Drawing.Size(167, 20);
            this.text_Sex.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGreen;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(372, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Sex";
            // 
            // text_Address
            // 
            this.text_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Address.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Address.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Address.Location = new System.Drawing.Point(112, 97);
            this.text_Address.Multiline = true;
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(499, 20);
            this.text_Address.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(17, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // text_MonthlyIncome
            // 
            this.text_MonthlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_MonthlyIncome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MonthlyIncome.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_MonthlyIncome.Location = new System.Drawing.Point(526, 123);
            this.text_MonthlyIncome.Multiline = true;
            this.text_MonthlyIncome.Name = "text_MonthlyIncome";
            this.text_MonthlyIncome.Size = new System.Drawing.Size(85, 20);
            this.text_MonthlyIncome.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(412, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "MonthlyIncome";
            // 
            // text_Occupation
            // 
            this.text_Occupation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Occupation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Occupation.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Occupation.Location = new System.Drawing.Point(112, 123);
            this.text_Occupation.Multiline = true;
            this.text_Occupation.Name = "text_Occupation";
            this.text_Occupation.Size = new System.Drawing.Size(290, 20);
            this.text_Occupation.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Occupation";
            // 
            // text_Birthdate
            // 
            this.text_Birthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Birthdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Birthdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Birthdate.Location = new System.Drawing.Point(444, 20);
            this.text_Birthdate.Multiline = true;
            this.text_Birthdate.Name = "text_Birthdate";
            this.text_Birthdate.Size = new System.Drawing.Size(167, 20);
            this.text_Birthdate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(372, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Birthdate";
            // 
            // text_Middlename
            // 
            this.text_Middlename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Middlename.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Middlename.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Middlename.Location = new System.Drawing.Point(112, 72);
            this.text_Middlename.Multiline = true;
            this.text_Middlename.Name = "text_Middlename";
            this.text_Middlename.Size = new System.Drawing.Size(229, 20);
            this.text_Middlename.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middlename";
            // 
            // text_Firstname
            // 
            this.text_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Firstname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Firstname.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Firstname.Location = new System.Drawing.Point(112, 46);
            this.text_Firstname.Multiline = true;
            this.text_Firstname.Name = "text_Firstname";
            this.text_Firstname.Size = new System.Drawing.Size(229, 20);
            this.text_Firstname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname";
            // 
            // text_Lastname
            // 
            this.text_Lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Lastname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Lastname.ForeColor = System.Drawing.Color.SeaGreen;
            this.text_Lastname.Location = new System.Drawing.Point(112, 20);
            this.text_Lastname.Multiline = true;
            this.text_Lastname.Name = "text_Lastname";
            this.text_Lastname.Size = new System.Drawing.Size(229, 20);
            this.text_Lastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnumberDataGridViewTextBoxColumn,
            this.householdnoDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.applicationstatusDataGridViewTextBoxColumn,
            this.verificationstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.verificationBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView1.Location = new System.Drawing.Point(3, 168);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 202);
            this.dataGridView1.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::AyudaSubsidySystem.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(813, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 10);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // ayudaDataSet
            // 
            this.ayudaDataSet.DataSetName = "AyudaDataSet";
            this.ayudaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationBindingSource
            // 
            this.verificationBindingSource.DataMember = "Verification";
            this.verificationBindingSource.DataSource = this.ayudaDataSet;
            // 
            // verificationTableAdapter
            // 
            this.verificationTableAdapter.ClearBeforeFill = true;
            // 
            // idnumberDataGridViewTextBoxColumn
            // 
            this.idnumberDataGridViewTextBoxColumn.DataPropertyName = "id_number";
            this.idnumberDataGridViewTextBoxColumn.HeaderText = "id_number";
            this.idnumberDataGridViewTextBoxColumn.Name = "idnumberDataGridViewTextBoxColumn";
            // 
            // householdnoDataGridViewTextBoxColumn
            // 
            this.householdnoDataGridViewTextBoxColumn.DataPropertyName = "household_no";
            this.householdnoDataGridViewTextBoxColumn.HeaderText = "household_no";
            this.householdnoDataGridViewTextBoxColumn.Name = "householdnoDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // applicationstatusDataGridViewTextBoxColumn
            // 
            this.applicationstatusDataGridViewTextBoxColumn.DataPropertyName = "application_status";
            this.applicationstatusDataGridViewTextBoxColumn.HeaderText = "application_status";
            this.applicationstatusDataGridViewTextBoxColumn.Name = "applicationstatusDataGridViewTextBoxColumn";
            // 
            // verificationstatusDataGridViewTextBoxColumn
            // 
            this.verificationstatusDataGridViewTextBoxColumn.DataPropertyName = "verification_status";
            this.verificationstatusDataGridViewTextBoxColumn.HeaderText = "verification_status";
            this.verificationstatusDataGridViewTextBoxColumn.Name = "verificationstatusDataGridViewTextBoxColumn";
            // 
            // Frm_Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(920, 472);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Verify";
            this.Text = "Frm_Verify";
            this.Load += new System.EventHandler(this.Frm_Verify_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayudaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox text_Contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Sex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_MonthlyIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Occupation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Birthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Middlename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AyudaDataSet ayudaDataSet;
        private System.Windows.Forms.BindingSource verificationBindingSource;
        private AyudaDataSetTableAdapters.VerificationTableAdapter verificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verificationstatusDataGridViewTextBoxColumn;
    }
}
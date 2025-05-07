namespace PetHavenManagementSystem
{
    partial class PetProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearch = new Guna.UI.WinForms.GunaButton();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwnerID = new Guna.UI.WinForms.GunaTextBox();
            this.txtGender = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBreed = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpecies = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPetName = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPetID = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnadd = new Guna.UI.WinForms.GunaGradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColor = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNeutered = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtIsAdopted = new Guna.UI.WinForms.GunaTextBox();
            this.txtExposure = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PETS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnsearch
            // 
            this.btnsearch.AnimationHoverSpeed = 0.07F;
            this.btnsearch.AnimationSpeed = 0.03F;
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnsearch.BorderColor = System.Drawing.Color.Black;
            this.btnsearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsearch.Location = new System.Drawing.Point(902, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsearch.OnHoverImage = null;
            this.btnsearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnsearch.Radius = 15;
            this.btnsearch.Size = new System.Drawing.Size(37, 29);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BaseColor = System.Drawing.Color.White;
            this.txtsearch.BorderColor = System.Drawing.Color.Black;
            this.txtsearch.BorderSize = 1;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.Location = new System.Drawing.Point(566, 9);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 15;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(330, 31);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextOffsetX = 10;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 99;
            this.label5.Text = "Owner ID:";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.BackColor = System.Drawing.Color.Transparent;
            this.txtOwnerID.BaseColor = System.Drawing.Color.White;
            this.txtOwnerID.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtOwnerID.BorderSize = 1;
            this.txtOwnerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnerID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOwnerID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOwnerID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOwnerID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerID.Location = new System.Drawing.Point(70, 427);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.PasswordChar = '\0';
            this.txtOwnerID.Radius = 8;
            this.txtOwnerID.SelectedText = "";
            this.txtOwnerID.Size = new System.Drawing.Size(86, 30);
            this.txtOwnerID.TabIndex = 98;
            this.txtOwnerID.TextOffsetX = 12;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BaseColor = System.Drawing.Color.White;
            this.txtGender.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtGender.BorderSize = 1;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGender.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(733, 352);
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.Radius = 8;
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(146, 30);
            this.txtGender.TabIndex = 96;
            this.txtGender.TextOffsetX = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 95;
            this.label3.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.BaseColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtAge.BorderSize = 1;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(383, 352);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.Radius = 8;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(130, 30);
            this.txtAge.TabIndex = 94;
            this.txtAge.TextOffsetX = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 93;
            this.label2.Text = "Birth Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 91;
            this.label7.Text = "Breed:";
            // 
            // txtBreed
            // 
            this.txtBreed.BackColor = System.Drawing.Color.Transparent;
            this.txtBreed.BaseColor = System.Drawing.Color.White;
            this.txtBreed.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtBreed.BorderSize = 1;
            this.txtBreed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBreed.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBreed.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBreed.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBreed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreed.Location = new System.Drawing.Point(546, 352);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.PasswordChar = '\0';
            this.txtBreed.Radius = 8;
            this.txtBreed.SelectedText = "";
            this.txtBreed.Size = new System.Drawing.Size(146, 30);
            this.txtBreed.TabIndex = 90;
            this.txtBreed.TextOffsetX = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 89;
            this.label9.Text = "Species:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.BackColor = System.Drawing.Color.Transparent;
            this.txtSpecies.BaseColor = System.Drawing.Color.White;
            this.txtSpecies.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtSpecies.BorderSize = 1;
            this.txtSpecies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecies.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSpecies.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSpecies.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSpecies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(198, 427);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.PasswordChar = '\0';
            this.txtSpecies.Radius = 8;
            this.txtSpecies.SelectedText = "";
            this.txtSpecies.Size = new System.Drawing.Size(145, 30);
            this.txtSpecies.TabIndex = 88;
            this.txtSpecies.TextOffsetX = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 87;
            this.label10.Text = "Pet Name:";
            // 
            // txtPetName
            // 
            this.txtPetName.BackColor = System.Drawing.Color.Transparent;
            this.txtPetName.BaseColor = System.Drawing.Color.White;
            this.txtPetName.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPetName.BorderSize = 1;
            this.txtPetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPetName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPetName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPetName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(198, 352);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.PasswordChar = '\0';
            this.txtPetName.Radius = 8;
            this.txtPetName.SelectedText = "";
            this.txtPetName.Size = new System.Drawing.Size(163, 30);
            this.txtPetName.TabIndex = 86;
            this.txtPetName.TextOffsetX = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "Pets ID:";
            // 
            // txtPetID
            // 
            this.txtPetID.BackColor = System.Drawing.Color.Transparent;
            this.txtPetID.BaseColor = System.Drawing.Color.White;
            this.txtPetID.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPetID.BorderSize = 1;
            this.txtPetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPetID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPetID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPetID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetID.Location = new System.Drawing.Point(70, 352);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.PasswordChar = '\0';
            this.txtPetID.Radius = 8;
            this.txtPetID.SelectedText = "";
            this.txtPetID.Size = new System.Drawing.Size(86, 30);
            this.txtPetID.TabIndex = 84;
            this.txtPetID.TextOffsetX = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(37, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(885, 257);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnupdate
            // 
            this.btnupdate.AnimationHoverSpeed = 0.07F;
            this.btnupdate.AnimationSpeed = 0.03F;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BaseColor1 = System.Drawing.Color.Blue;
            this.btnupdate.BaseColor2 = System.Drawing.Color.Navy;
            this.btnupdate.BorderColor = System.Drawing.Color.Black;
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnupdate.Location = new System.Drawing.Point(609, 502);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnupdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 12;
            this.btnupdate.Size = new System.Drawing.Size(104, 38);
            this.btnupdate.TabIndex = 82;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton3.Image")));
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(719, 502);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Radius = 12;
            this.gunaGradientButton3.Size = new System.Drawing.Size(90, 38);
            this.gunaGradientButton3.TabIndex = 81;
            this.gunaGradientButton3.Text = "Delete";
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // btnadd
            // 
            this.btnadd.AnimationHoverSpeed = 0.07F;
            this.btnadd.AnimationSpeed = 0.03F;
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BaseColor1 = System.Drawing.Color.DarkOrchid;
            this.btnadd.BaseColor2 = System.Drawing.Color.Indigo;
            this.btnadd.BorderColor = System.Drawing.Color.Black;
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnadd.FocusedColor = System.Drawing.Color.Empty;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnadd.Location = new System.Drawing.Point(509, 502);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnadd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnPressedColor = System.Drawing.Color.Black;
            this.btnadd.Radius = 10;
            this.btnadd.Size = new System.Drawing.Size(84, 38);
            this.btnadd.TabIndex = 80;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "IsNeutered:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(380, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 105;
            this.label12.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Transparent;
            this.txtColor.BaseColor = System.Drawing.Color.White;
            this.txtColor.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtColor.BorderSize = 1;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtColor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtColor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(383, 427);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.Radius = 8;
            this.txtColor.SelectedText = "";
            this.txtColor.Size = new System.Drawing.Size(119, 30);
            this.txtColor.TabIndex = 104;
            this.txtColor.TextOffsetX = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(713, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 101;
            this.label11.Text = "Exposure:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(532, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 107;
            this.label13.Text = "IsAdopted:";
            // 
            // cmbNeutered
            // 
            this.cmbNeutered.FormattingEnabled = true;
            this.cmbNeutered.Location = new System.Drawing.Point(301, 502);
            this.cmbNeutered.Name = "cmbNeutered";
            this.cmbNeutered.Size = new System.Drawing.Size(133, 21);
            this.cmbNeutered.TabIndex = 108;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(51, 499);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(179, 20);
            this.dtpBirthdate.TabIndex = 110;
            // 
            // txtIsAdopted
            // 
            this.txtIsAdopted.BackColor = System.Drawing.Color.Transparent;
            this.txtIsAdopted.BaseColor = System.Drawing.Color.White;
            this.txtIsAdopted.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtIsAdopted.BorderSize = 1;
            this.txtIsAdopted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsAdopted.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIsAdopted.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIsAdopted.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIsAdopted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsAdopted.Location = new System.Drawing.Point(535, 427);
            this.txtIsAdopted.Name = "txtIsAdopted";
            this.txtIsAdopted.PasswordChar = '\0';
            this.txtIsAdopted.Radius = 8;
            this.txtIsAdopted.SelectedText = "";
            this.txtIsAdopted.Size = new System.Drawing.Size(133, 30);
            this.txtIsAdopted.TabIndex = 106;
            this.txtIsAdopted.TextOffsetX = 12;
            // 
            // txtExposure
            // 
            this.txtExposure.BackColor = System.Drawing.Color.Transparent;
            this.txtExposure.BaseColor = System.Drawing.Color.White;
            this.txtExposure.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtExposure.BorderSize = 1;
            this.txtExposure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExposure.FocusedBaseColor = System.Drawing.Color.White;
            this.txtExposure.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExposure.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtExposure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExposure.Location = new System.Drawing.Point(722, 427);
            this.txtExposure.Name = "txtExposure";
            this.txtExposure.PasswordChar = '\0';
            this.txtExposure.Radius = 8;
            this.txtExposure.SelectedText = "";
            this.txtExposure.Size = new System.Drawing.Size(124, 30);
            this.txtExposure.TabIndex = 111;
            this.txtExposure.TextOffsetX = 12;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.DeepPink;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.PaleVioletRed;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(818, 502);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 12;
            this.gunaGradientButton1.Size = new System.Drawing.Size(104, 38);
            this.gunaGradientButton1.TabIndex = 112;
            this.gunaGradientButton1.Text = "Clear";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // PetProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.txtExposure);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.cmbNeutered);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIsAdopted);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.gunaGradientButton3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PetProfile";
            this.Text = "PetProfile";
            this.Load += new System.EventHandler(this.PetProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnsearch;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtOwnerID;
        private Guna.UI.WinForms.GunaTextBox txtGender;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtBreed;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtSpecies;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txtPetName;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtPetID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaGradientButton btnupdate;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaGradientButton btnadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaTextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNeutered;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private Guna.UI.WinForms.GunaTextBox txtIsAdopted;
        private Guna.UI.WinForms.GunaTextBox txtExposure;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}
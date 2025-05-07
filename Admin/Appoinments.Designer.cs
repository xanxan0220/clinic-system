namespace PetHavenManagementSystem
{
    partial class Appoinments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appoinments));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearch = new Guna.UI.WinForms.GunaButton();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnadd = new Guna.UI.WinForms.GunaGradientButton();
            this.txtappointmentId = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvetid = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtownerid = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttime = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnotes = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstatus = new Guna.UI.WinForms.GunaTextBox();
            this.txtpetid = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 47);
            this.panel2.TabIndex = 13;
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
            this.btnsearch.Location = new System.Drawing.Point(899, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsearch.OnHoverImage = null;
            this.btnsearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnsearch.Radius = 15;
            this.btnsearch.Size = new System.Drawing.Size(37, 29);
            this.btnsearch.TabIndex = 10;
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
            this.txtsearch.Location = new System.Drawing.Point(563, 9);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 15;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(330, 31);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextOffsetX = 10;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "APPOINTMENT\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(920, 276);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.btnupdate.Location = new System.Drawing.Point(722, 509);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnupdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 12;
            this.btnupdate.Size = new System.Drawing.Size(104, 38);
            this.btnupdate.TabIndex = 36;
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
            this.gunaGradientButton3.Location = new System.Drawing.Point(616, 509);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Radius = 12;
            this.gunaGradientButton3.Size = new System.Drawing.Size(90, 38);
            this.gunaGradientButton3.TabIndex = 35;
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
            this.btnadd.Location = new System.Drawing.Point(514, 509);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnadd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnadd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnPressedColor = System.Drawing.Color.Black;
            this.btnadd.Radius = 10;
            this.btnadd.Size = new System.Drawing.Size(84, 38);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtappointmentId
            // 
            this.txtappointmentId.BackColor = System.Drawing.Color.Transparent;
            this.txtappointmentId.BaseColor = System.Drawing.Color.White;
            this.txtappointmentId.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtappointmentId.BorderSize = 1;
            this.txtappointmentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtappointmentId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtappointmentId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtappointmentId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtappointmentId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappointmentId.Location = new System.Drawing.Point(86, 368);
            this.txtappointmentId.Name = "txtappointmentId";
            this.txtappointmentId.PasswordChar = '\0';
            this.txtappointmentId.Radius = 8;
            this.txtappointmentId.SelectedText = "";
            this.txtappointmentId.Size = new System.Drawing.Size(83, 30);
            this.txtappointmentId.TabIndex = 38;
            this.txtappointmentId.TextOffsetX = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Appointment ID:";
            // 
            // txtvetid
            // 
            this.txtvetid.BackColor = System.Drawing.Color.Transparent;
            this.txtvetid.BaseColor = System.Drawing.Color.White;
            this.txtvetid.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtvetid.BorderSize = 1;
            this.txtvetid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvetid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtvetid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtvetid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtvetid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvetid.Location = new System.Drawing.Point(86, 436);
            this.txtvetid.Name = "txtvetid";
            this.txtvetid.PasswordChar = '\0';
            this.txtvetid.Radius = 8;
            this.txtvetid.SelectedText = "";
            this.txtvetid.Size = new System.Drawing.Size(83, 30);
            this.txtvetid.TabIndex = 40;
            this.txtvetid.TextOffsetX = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "VetID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "PetID:";
            // 
            // txtownerid
            // 
            this.txtownerid.BackColor = System.Drawing.Color.Transparent;
            this.txtownerid.BaseColor = System.Drawing.Color.White;
            this.txtownerid.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtownerid.BorderSize = 1;
            this.txtownerid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtownerid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtownerid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtownerid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtownerid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtownerid.Location = new System.Drawing.Point(225, 436);
            this.txtownerid.Name = "txtownerid";
            this.txtownerid.PasswordChar = '\0';
            this.txtownerid.Radius = 8;
            this.txtownerid.SelectedText = "";
            this.txtownerid.Size = new System.Drawing.Size(91, 30);
            this.txtownerid.TabIndex = 44;
            this.txtownerid.TextOffsetX = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "OwnerID:";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.BaseColor = System.Drawing.Color.White;
            this.txtdate.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtdate.BorderSize = 1;
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(381, 368);
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.Radius = 8;
            this.txtdate.SelectedText = "";
            this.txtdate.Size = new System.Drawing.Size(217, 30);
            this.txtdate.TabIndex = 46;
            this.txtdate.TextOffsetX = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Appointment Date:";
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.Color.Transparent;
            this.txttime.BaseColor = System.Drawing.Color.White;
            this.txttime.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txttime.BorderSize = 1;
            this.txttime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttime.FocusedBaseColor = System.Drawing.Color.White;
            this.txttime.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttime.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(381, 436);
            this.txttime.Name = "txttime";
            this.txttime.PasswordChar = '\0';
            this.txttime.Radius = 8;
            this.txttime.SelectedText = "";
            this.txttime.Size = new System.Drawing.Size(217, 30);
            this.txttime.TabIndex = 48;
            this.txttime.TextOffsetX = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Appointment Time:";
            // 
            // txtnotes
            // 
            this.txtnotes.BackColor = System.Drawing.Color.Transparent;
            this.txtnotes.BaseColor = System.Drawing.Color.White;
            this.txtnotes.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtnotes.BorderSize = 1;
            this.txtnotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnotes.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotes.Location = new System.Drawing.Point(651, 368);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.PasswordChar = '\0';
            this.txtnotes.Radius = 8;
            this.txtnotes.SelectedText = "";
            this.txtnotes.Size = new System.Drawing.Size(223, 30);
            this.txtnotes.TabIndex = 50;
            this.txtnotes.TextOffsetX = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Appointment Notes:";
            // 
            // txtstatus
            // 
            this.txtstatus.BackColor = System.Drawing.Color.Transparent;
            this.txtstatus.BaseColor = System.Drawing.Color.White;
            this.txtstatus.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtstatus.BorderSize = 1;
            this.txtstatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstatus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtstatus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtstatus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(651, 436);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.PasswordChar = '\0';
            this.txtstatus.Radius = 8;
            this.txtstatus.SelectedText = "";
            this.txtstatus.Size = new System.Drawing.Size(223, 30);
            this.txtstatus.TabIndex = 52;
            this.txtstatus.TextOffsetX = 12;
            // 
            // txtpetid
            // 
            this.txtpetid.BackColor = System.Drawing.Color.Transparent;
            this.txtpetid.BaseColor = System.Drawing.Color.White;
            this.txtpetid.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtpetid.BorderSize = 1;
            this.txtpetid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpetid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpetid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpetid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpetid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpetid.Location = new System.Drawing.Point(225, 368);
            this.txtpetid.Name = "txtpetid";
            this.txtpetid.PasswordChar = '\0';
            this.txtpetid.Radius = 8;
            this.txtpetid.SelectedText = "";
            this.txtpetid.Size = new System.Drawing.Size(91, 30);
            this.txtpetid.TabIndex = 42;
            this.txtpetid.TextOffsetX = 12;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(832, 509);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 12;
            this.gunaGradientButton1.Size = new System.Drawing.Size(104, 38);
            this.gunaGradientButton1.TabIndex = 54;
            this.gunaGradientButton1.Text = "Clear";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // Appoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtownerid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpetid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvetid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtappointmentId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.gunaGradientButton3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appoinments";
            this.Text = "Appoinments";
            this.Load += new System.EventHandler(this.Appoinments_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnsearch;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaGradientButton btnupdate;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaGradientButton btnadd;
        private Guna.UI.WinForms.GunaTextBox txtappointmentId;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtvetid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtownerid;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtdate;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txttime;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtnotes;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtstatus;
        private Guna.UI.WinForms.GunaTextBox txtpetid;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}
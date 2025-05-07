namespace PetHavenManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblMemberships = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDoctorscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblAppointmentscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblOwnerscount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.chartAppointments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.chartSpeciesDoughnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gunaElipsePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointments)).BeginInit();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeciesDoughnut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblGreeting);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGreeting.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Black;
            this.lblGreeting.Location = new System.Drawing.Point(396, 11);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(204, 19);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Good Morning, Admin!";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.lblClock);
            this.panel3.Location = new System.Drawing.Point(756, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 32);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(51, 8);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(56, 17);
            this.lblClock.TabIndex = 20;
            this.lblClock.Text = "6:36 AM\r\n";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.gunaElipsePanel4);
            this.panel2.Controls.Add(this.gunaElipsePanel3);
            this.panel2.Controls.Add(this.gunaElipsePanel2);
            this.panel2.Controls.Add(this.gunaElipsePanel1);
            this.panel2.Controls.Add(this.gunaShadowPanel1);
            this.panel2.Controls.Add(this.gunaShadowPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 527);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(31, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "New Registered Owners\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(508, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Recent Appointments";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(501, 392);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(430, 123);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 121);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel4.Controls.Add(this.lblMemberships);
            this.gunaElipsePanel4.Controls.Add(this.label9);
            this.gunaElipsePanel4.Controls.Add(this.pictureBox4);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(723, 9);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 10;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(208, 97);
            this.gunaElipsePanel4.TabIndex = 11;
            this.gunaElipsePanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel4_Paint);
            // 
            // lblMemberships
            // 
            this.lblMemberships.AutoSize = true;
            this.lblMemberships.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberships.Location = new System.Drawing.Point(186, 71);
            this.lblMemberships.Name = "lblMemberships";
            this.lblMemberships.Size = new System.Drawing.Size(15, 15);
            this.lblMemberships.TabIndex = 4;
            this.lblMemberships.Text = "0";
            this.lblMemberships.Click += new System.EventHandler(this.lblMemberships_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "TOTAL\r\nUPGRADE\r\n\r\n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.pictureBox3);
            this.gunaElipsePanel3.Controls.Add(this.lblDoctorscount);
            this.gunaElipsePanel3.Controls.Add(this.label7);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(492, 9);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 10;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(225, 97);
            this.gunaElipsePanel3.TabIndex = 10;
            this.gunaElipsePanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel3_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblDoctorscount
            // 
            this.lblDoctorscount.AutoSize = true;
            this.lblDoctorscount.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorscount.Location = new System.Drawing.Point(196, 71);
            this.lblDoctorscount.Name = "lblDoctorscount";
            this.lblDoctorscount.Size = new System.Drawing.Size(15, 15);
            this.lblDoctorscount.TabIndex = 4;
            this.lblDoctorscount.Text = "0";
            this.lblDoctorscount.Click += new System.EventHandler(this.lblDoctorscount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "TOTAL\r\nDOCTORS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.lblAppointmentscount);
            this.gunaElipsePanel2.Controls.Add(this.label5);
            this.gunaElipsePanel2.Controls.Add(this.pictureBox2);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(252, 9);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 10;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(234, 97);
            this.gunaElipsePanel2.TabIndex = 9;
            this.gunaElipsePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel2_Paint);
            // 
            // lblAppointmentscount
            // 
            this.lblAppointmentscount.AutoSize = true;
            this.lblAppointmentscount.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentscount.Location = new System.Drawing.Point(190, 71);
            this.lblAppointmentscount.Name = "lblAppointmentscount";
            this.lblAppointmentscount.Size = new System.Drawing.Size(15, 15);
            this.lblAppointmentscount.TabIndex = 4;
            this.lblAppointmentscount.Text = "0";
            this.lblAppointmentscount.Click += new System.EventHandler(this.lblAppointmentscount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "TOTAL\r\nAPPOINTMENTS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.lblOwnerscount);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(20, 9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(226, 97);
            this.gunaElipsePanel1.TabIndex = 8;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // lblOwnerscount
            // 
            this.lblOwnerscount.AutoSize = true;
            this.lblOwnerscount.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerscount.Location = new System.Drawing.Point(195, 71);
            this.lblOwnerscount.Name = "lblOwnerscount";
            this.lblOwnerscount.Size = new System.Drawing.Size(15, 15);
            this.lblOwnerscount.TabIndex = 2;
            this.lblOwnerscount.Text = "0";
            this.lblOwnerscount.Click += new System.EventHandler(this.lblOwnerscount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL \r\nOWNERS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.chartAppointments);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(12, 112);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.gunaShadowPanel1.Size = new System.Drawing.Size(500, 258);
            this.gunaShadowPanel1.TabIndex = 30;
            // 
            // chartAppointments
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAppointments.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAppointments.Legends.Add(legend1);
            this.chartAppointments.Location = new System.Drawing.Point(22, 15);
            this.chartAppointments.Name = "chartAppointments";
            this.chartAppointments.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAppointments.Series.Add(series1);
            this.chartAppointments.Size = new System.Drawing.Size(462, 227);
            this.chartAppointments.TabIndex = 13;
            this.chartAppointments.Text = "chart2";
            this.chartAppointments.Click += new System.EventHandler(this.chartAppointments_Click);
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.chartSpeciesDoughnut);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(518, 112);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 5;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.gunaShadowPanel2.Size = new System.Drawing.Size(420, 258);
            this.gunaShadowPanel2.TabIndex = 31;
            // 
            // chartSpeciesDoughnut
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSpeciesDoughnut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSpeciesDoughnut.Legends.Add(legend2);
            this.chartSpeciesDoughnut.Location = new System.Drawing.Point(18, 15);
            this.chartSpeciesDoughnut.Name = "chartSpeciesDoughnut";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSpeciesDoughnut.Series.Add(series2);
            this.chartSpeciesDoughnut.Size = new System.Drawing.Size(388, 227);
            this.chartSpeciesDoughnut.TabIndex = 12;
            this.chartSpeciesDoughnut.Text = "chart3";
            this.chartSpeciesDoughnut.Click += new System.EventHandler(this.chartSpeciesDoughnut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointments)).EndInit();
            this.gunaShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeciesDoughnut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeciesDoughnut;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Label lblDoctorscount;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label lblAppointmentscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label lblOwnerscount;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private System.Windows.Forms.Label lblMemberships;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace PetHavenManagementSystem
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtpschedule = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxreason = new Guna.UI.WinForms.GunaComboBox();
            this.cbxspecify = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnschedule = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttime = new Guna.UI.WinForms.GunaTextBox();
            this.cbxOwnerName = new Guna.UI.WinForms.GunaComboBox();
            this.cbxPetname = new Guna.UI.WinForms.GunaComboBox();
            this.cbxDoctorname = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(543, 38);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 24);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Vet Appointment";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // dtpschedule
            // 
            this.dtpschedule.BackColor = System.Drawing.Color.Transparent;
            this.dtpschedule.BaseColor = System.Drawing.Color.White;
            this.dtpschedule.BorderColor = System.Drawing.Color.Silver;
            this.dtpschedule.CustomFormat = null;
            this.dtpschedule.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpschedule.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpschedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpschedule.ForeColor = System.Drawing.Color.Black;
            this.dtpschedule.Location = new System.Drawing.Point(148, 285);
            this.dtpschedule.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpschedule.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpschedule.Name = "dtpschedule";
            this.dtpschedule.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpschedule.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpschedule.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpschedule.OnPressedColor = System.Drawing.Color.Black;
            this.dtpschedule.Radius = 5;
            this.dtpschedule.Size = new System.Drawing.Size(223, 30);
            this.dtpschedule.TabIndex = 8;
            this.dtpschedule.Text = "Monday, April 14, 2025";
            this.dtpschedule.Value = new System.DateTime(2025, 4, 14, 0, 0, 0, 0);
            this.dtpschedule.ValueChanged += new System.EventHandler(this.dtmschedule_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Owner\'s Fullname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Petname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Reason for Visit:";
            // 
            // cbxreason
            // 
            this.cbxreason.BackColor = System.Drawing.Color.Transparent;
            this.cbxreason.BaseColor = System.Drawing.Color.White;
            this.cbxreason.BorderColor = System.Drawing.Color.Silver;
            this.cbxreason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxreason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxreason.FocusedColor = System.Drawing.Color.Empty;
            this.cbxreason.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxreason.ForeColor = System.Drawing.Color.Black;
            this.cbxreason.FormattingEnabled = true;
            this.cbxreason.Location = new System.Drawing.Point(134, 370);
            this.cbxreason.Name = "cbxreason";
            this.cbxreason.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxreason.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxreason.Radius = 5;
            this.cbxreason.Size = new System.Drawing.Size(426, 26);
            this.cbxreason.TabIndex = 28;
            this.cbxreason.SelectedIndexChanged += new System.EventHandler(this.cbxreason_SelectedIndexChanged);
            // 
            // cbxspecify
            // 
            this.cbxspecify.BackColor = System.Drawing.Color.Transparent;
            this.cbxspecify.BaseColor = System.Drawing.Color.White;
            this.cbxspecify.BorderColor = System.Drawing.Color.Silver;
            this.cbxspecify.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxspecify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxspecify.FocusedColor = System.Drawing.Color.Empty;
            this.cbxspecify.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxspecify.ForeColor = System.Drawing.Color.Black;
            this.cbxspecify.FormattingEnabled = true;
            this.cbxspecify.Location = new System.Drawing.Point(134, 445);
            this.cbxspecify.Name = "cbxspecify";
            this.cbxspecify.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxspecify.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxspecify.Radius = 5;
            this.cbxspecify.Size = new System.Drawing.Size(426, 26);
            this.cbxspecify.TabIndex = 29;
            this.cbxspecify.SelectedIndexChanged += new System.EventHandler(this.cbxspecify_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kindly specify:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.gunaLabel2.Location = new System.Drawing.Point(490, 81);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(308, 17);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Share with us what care you need for your pet!\r\n";
            // 
            // btnschedule
            // 
            this.btnschedule.AnimationHoverSpeed = 0.07F;
            this.btnschedule.AnimationSpeed = 0.03F;
            this.btnschedule.BackColor = System.Drawing.Color.Transparent;
            this.btnschedule.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnschedule.BorderColor = System.Drawing.Color.Black;
            this.btnschedule.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnschedule.FocusedColor = System.Drawing.Color.Empty;
            this.btnschedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.Image = null;
            this.btnschedule.ImageSize = new System.Drawing.Size(20, 20);
            this.btnschedule.Location = new System.Drawing.Point(289, 526);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnschedule.OnHoverBorderColor = System.Drawing.Color.BlueViolet;
            this.btnschedule.OnHoverForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnschedule.OnHoverImage = null;
            this.btnschedule.OnPressedColor = System.Drawing.Color.Black;
            this.btnschedule.Radius = 15;
            this.btnschedule.Size = new System.Drawing.Size(161, 49);
            this.btnschedule.TabIndex = 31;
            this.btnschedule.Text = "Schedule!";
            this.btnschedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(651, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 500);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Time:\r\n";
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.Color.Transparent;
            this.txttime.BaseColor = System.Drawing.Color.White;
            this.txttime.BorderColor = System.Drawing.Color.Silver;
            this.txttime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttime.FocusedBaseColor = System.Drawing.Color.White;
            this.txttime.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttime.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(449, 223);
            this.txttime.Name = "txttime";
            this.txttime.PasswordChar = '\0';
            this.txttime.Radius = 12;
            this.txttime.SelectedText = "";
            this.txttime.Size = new System.Drawing.Size(125, 30);
            this.txttime.TabIndex = 36;
            this.txttime.TextOffsetX = 12;
            // 
            // cbxOwnerName
            // 
            this.cbxOwnerName.BackColor = System.Drawing.Color.Transparent;
            this.cbxOwnerName.BaseColor = System.Drawing.Color.White;
            this.cbxOwnerName.BorderColor = System.Drawing.Color.Silver;
            this.cbxOwnerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxOwnerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOwnerName.FocusedColor = System.Drawing.Color.Empty;
            this.cbxOwnerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxOwnerName.ForeColor = System.Drawing.Color.Black;
            this.cbxOwnerName.FormattingEnabled = true;
            this.cbxOwnerName.Location = new System.Drawing.Point(148, 151);
            this.cbxOwnerName.Name = "cbxOwnerName";
            this.cbxOwnerName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxOwnerName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxOwnerName.Radius = 5;
            this.cbxOwnerName.Size = new System.Drawing.Size(200, 26);
            this.cbxOwnerName.TabIndex = 37;
            this.cbxOwnerName.SelectedIndexChanged += new System.EventHandler(this.cbxOwnerName_SelectedIndexChanged);
            // 
            // cbxPetname
            // 
            this.cbxPetname.BackColor = System.Drawing.Color.Transparent;
            this.cbxPetname.BaseColor = System.Drawing.Color.White;
            this.cbxPetname.BorderColor = System.Drawing.Color.Silver;
            this.cbxPetname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPetname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPetname.FocusedColor = System.Drawing.Color.Empty;
            this.cbxPetname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPetname.ForeColor = System.Drawing.Color.Black;
            this.cbxPetname.FormattingEnabled = true;
            this.cbxPetname.Location = new System.Drawing.Point(413, 151);
            this.cbxPetname.Name = "cbxPetname";
            this.cbxPetname.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxPetname.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxPetname.Radius = 5;
            this.cbxPetname.Size = new System.Drawing.Size(186, 26);
            this.cbxPetname.TabIndex = 38;
            this.cbxPetname.SelectedIndexChanged += new System.EventHandler(this.cbxPetname_SelectedIndexChanged);
            // 
            // cbxDoctorname
            // 
            this.cbxDoctorname.BackColor = System.Drawing.Color.Transparent;
            this.cbxDoctorname.BaseColor = System.Drawing.Color.White;
            this.cbxDoctorname.BorderColor = System.Drawing.Color.Silver;
            this.cbxDoctorname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDoctorname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoctorname.FocusedColor = System.Drawing.Color.Empty;
            this.cbxDoctorname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDoctorname.ForeColor = System.Drawing.Color.Black;
            this.cbxDoctorname.FormattingEnabled = true;
            this.cbxDoctorname.Location = new System.Drawing.Point(148, 227);
            this.cbxDoctorname.Name = "cbxDoctorname";
            this.cbxDoctorname.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxDoctorname.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxDoctorname.Radius = 5;
            this.cbxDoctorname.Size = new System.Drawing.Size(200, 26);
            this.cbxDoctorname.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doctor\' Name:";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.Controls.Add(this.cbxDoctorname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxPetname);
            this.Controls.Add(this.cbxOwnerName);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnschedule);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxspecify);
            this.Controls.Add(this.cbxreason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpschedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpschedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbxreason;
        private Guna.UI.WinForms.GunaComboBox cbxspecify;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnschedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txttime;
        private Guna.UI.WinForms.GunaComboBox cbxOwnerName;
        private Guna.UI.WinForms.GunaComboBox cbxPetname;
        private Guna.UI.WinForms.GunaComboBox cbxDoctorname;
        private System.Windows.Forms.Label label7;
    }
}
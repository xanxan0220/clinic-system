namespace PetHavenManagementSystem.Components
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregister = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtfullname = new Guna.UI.WinForms.GunaTextBox();
            this.linklbalreadyhaveanaccount = new System.Windows.Forms.LinkLabel();
            this.ppcxProfileImport = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.txtaddress = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImageImport = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "User Type:";
            // 
            // cmbrole
            // 
            this.cmbrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(138, 406);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(143, 23);
            this.cmbrole.TabIndex = 53;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.cbxusertype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(365, 313);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Radius = 15;
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(246, 33);
            this.txtemail.TabIndex = 51;
            this.txtemail.TextOffsetX = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fullname:";
            // 
            // btnregister
            // 
            this.btnregister.AnimationHoverSpeed = 0.07F;
            this.btnregister.AnimationSpeed = 0.03F;
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BaseColor1 = System.Drawing.Color.Blue;
            this.btnregister.BaseColor2 = System.Drawing.Color.Indigo;
            this.btnregister.BorderColor = System.Drawing.Color.Black;
            this.btnregister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnregister.FocusedColor = System.Drawing.Color.Empty;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Image = null;
            this.btnregister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnregister.Location = new System.Drawing.Point(253, 533);
            this.btnregister.Name = "btnregister";
            this.btnregister.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnregister.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnregister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnregister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnregister.OnHoverImage = null;
            this.btnregister.OnPressedColor = System.Drawing.Color.Black;
            this.btnregister.Radius = 15;
            this.btnregister.Size = new System.Drawing.Size(161, 45);
            this.btnregister.TabIndex = 47;
            this.btnregister.Text = "Register";
            this.btnregister.TextOffsetX = 50;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registration Form";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(369, 239);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.Radius = 15;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(242, 33);
            this.txtpassword.TabIndex = 44;
            this.txtpassword.TextOffsetX = 12;
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.Transparent;
            this.txtfullname.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtfullname.BorderColor = System.Drawing.Color.Silver;
            this.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfullname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtfullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtfullname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtfullname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(368, 113);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.PasswordChar = '\0';
            this.txtfullname.Radius = 15;
            this.txtfullname.SelectedText = "";
            this.txtfullname.Size = new System.Drawing.Size(242, 33);
            this.txtfullname.TabIndex = 43;
            this.txtfullname.TextOffsetX = 12;
            // 
            // linklbalreadyhaveanaccount
            // 
            this.linklbalreadyhaveanaccount.AutoSize = true;
            this.linklbalreadyhaveanaccount.Location = new System.Drawing.Point(538, 585);
            this.linklbalreadyhaveanaccount.Name = "linklbalreadyhaveanaccount";
            this.linklbalreadyhaveanaccount.Size = new System.Drawing.Size(132, 13);
            this.linklbalreadyhaveanaccount.TabIndex = 42;
            this.linklbalreadyhaveanaccount.TabStop = true;
            this.linklbalreadyhaveanaccount.Text = "Already have an account?";
            this.linklbalreadyhaveanaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbalreadyhaveanaccount_LinkClicked);
            // 
            // ppcxProfileImport
            // 
            this.ppcxProfileImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ppcxProfileImport.BackgroundImage")));
            this.ppcxProfileImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ppcxProfileImport.Location = new System.Drawing.Point(45, 109);
            this.ppcxProfileImport.Name = "ppcxProfileImport";
            this.ppcxProfileImport.Size = new System.Drawing.Size(268, 207);
            this.ppcxProfileImport.TabIndex = 41;
            this.ppcxProfileImport.Paint += new System.Windows.Forms.PaintEventHandler(this.ppcxProfileImport_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 56;
            this.label7.Text = "Contact No.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.Transparent;
            this.txtphone.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtphone.BorderColor = System.Drawing.Color.Silver;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtphone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtphone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtphone.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(361, 388);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.Radius = 15;
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(246, 34);
            this.txtphone.TabIndex = 55;
            this.txtphone.TextOffsetX = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.gunaButton1);
            this.panel2.Controls.Add(this.gunaButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 30);
            this.panel2.TabIndex = 57;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(621, -16);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(38, 46);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(653, 0);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(40, 28);
            this.gunaButton2.TabIndex = 2;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 26);
            this.label8.TabIndex = 59;
            this.label8.Text = "Username:";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.username.BorderColor = System.Drawing.Color.Silver;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(365, 177);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 15;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(242, 33);
            this.username.TabIndex = 58;
            this.username.TextOffsetX = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Transparent;
            this.txtaddress.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtaddress.BorderColor = System.Drawing.Color.Silver;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(361, 465);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.Radius = 15;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(246, 34);
            this.txtaddress.TabIndex = 45;
            this.txtaddress.TextOffsetX = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Address:";
            // 
            // btnImageImport
            // 
            this.btnImageImport.AnimationHoverSpeed = 0.07F;
            this.btnImageImport.AnimationSpeed = 0.03F;
            this.btnImageImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImageImport.BaseColor1 = System.Drawing.Color.Blue;
            this.btnImageImport.BaseColor2 = System.Drawing.Color.Indigo;
            this.btnImageImport.BorderColor = System.Drawing.Color.Black;
            this.btnImageImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImageImport.FocusedColor = System.Drawing.Color.Empty;
            this.btnImageImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImageImport.ForeColor = System.Drawing.Color.White;
            this.btnImageImport.Image = null;
            this.btnImageImport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImageImport.Location = new System.Drawing.Point(45, 313);
            this.btnImageImport.Name = "btnImageImport";
            this.btnImageImport.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnImageImport.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnImageImport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImageImport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImageImport.OnHoverImage = null;
            this.btnImageImport.OnPressedColor = System.Drawing.Color.Black;
            this.btnImageImport.Radius = 5;
            this.btnImageImport.Size = new System.Drawing.Size(268, 45);
            this.btnImageImport.TabIndex = 60;
            this.btnImageImport.Text = "Add Image";
            this.btnImageImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImageImport.Click += new System.EventHandler(this.btnImageImport_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 617);
            this.Controls.Add(this.btnImageImport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.linklbalreadyhaveanaccount);
            this.Controls.Add(this.ppcxProfileImport);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Registration Form";
            this.Load += new System.EventHandler(this.AdminRegisterForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btnregister;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaTextBox txtfullname;
        private System.Windows.Forms.LinkLabel linklbalreadyhaveanaccount;
        private System.Windows.Forms.Panel ppcxProfileImport;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtphone;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtaddress;
        private Guna.UI.WinForms.GunaGradientButton btnImageImport;
    }
}
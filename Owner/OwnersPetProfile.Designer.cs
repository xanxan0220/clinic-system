namespace PetHavenManagementSystem
{
    partial class OwnersPetProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnersPetProfile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnaddpet = new Guna.UI.WinForms.GunaGradientButton();
            this.btndelete = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridViewPets = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddpet
            // 
            this.btnaddpet.AnimationHoverSpeed = 0.07F;
            this.btnaddpet.AnimationSpeed = 0.03F;
            this.btnaddpet.BackColor = System.Drawing.Color.Transparent;
            this.btnaddpet.BaseColor1 = System.Drawing.Color.Blue;
            this.btnaddpet.BaseColor2 = System.Drawing.Color.Navy;
            this.btnaddpet.BorderColor = System.Drawing.Color.Black;
            this.btnaddpet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddpet.FocusedColor = System.Drawing.Color.Empty;
            this.btnaddpet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaddpet.ForeColor = System.Drawing.Color.White;
            this.btnaddpet.Image = ((System.Drawing.Image)(resources.GetObject("btnaddpet.Image")));
            this.btnaddpet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnaddpet.Location = new System.Drawing.Point(975, 54);
            this.btnaddpet.Name = "btnaddpet";
            this.btnaddpet.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnaddpet.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnaddpet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnaddpet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnaddpet.OnHoverImage = null;
            this.btnaddpet.OnPressedColor = System.Drawing.Color.Black;
            this.btnaddpet.Radius = 10;
            this.btnaddpet.Size = new System.Drawing.Size(74, 26);
            this.btnaddpet.TabIndex = 2;
            this.btnaddpet.Text = "Add";
            this.btnaddpet.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // btndelete
            // 
            this.btndelete.AnimationHoverSpeed = 0.07F;
            this.btndelete.AnimationSpeed = 0.03F;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.BorderColor = System.Drawing.Color.Black;
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndelete.FocusedColor = System.Drawing.Color.Empty;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btndelete.Location = new System.Drawing.Point(1055, 54);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btndelete.OnHoverImage = null;
            this.btndelete.OnPressedColor = System.Drawing.Color.Black;
            this.btndelete.Radius = 12;
            this.btndelete.Size = new System.Drawing.Size(38, 26);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Add";
            this.btndelete.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 38);
            this.panel1.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(543, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(107, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "List Of Pets\r\n";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.AllowUserToResizeColumns = false;
            this.dataGridViewPets.AllowUserToResizeRows = false;
            this.dataGridViewPets.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPets.Location = new System.Drawing.Point(62, 86);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.ReadOnly = true;
            this.dataGridViewPets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPets.Size = new System.Drawing.Size(1055, 457);
            this.dataGridViewPets.TabIndex = 17;
            // 
            // OwnersPetProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 597);
            this.Controls.Add(this.dataGridViewPets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnaddpet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnersPetProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnersPetProfile";
            this.Load += new System.EventHandler(this.OwnersPetProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btnaddpet;
        private Guna.UI.WinForms.GunaGradientButton btndelete;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dataGridViewPets;
    }
}
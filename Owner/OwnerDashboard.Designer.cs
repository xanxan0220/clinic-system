namespace PetHavenManagementSystem
{
    partial class OwnerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerDashboard));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.gunaGradientButton5 = new Guna.UI.WinForms.GunaGradientButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.AutoScroll = true;
            this.mainpanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainpanel.Controls.Add(this.gunaGradientButton5);
            this.mainpanel.Controls.Add(this.tableLayoutPanel2);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1180, 600);
            this.mainpanel.TabIndex = 11;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaGradientButton5
            // 
            this.gunaGradientButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton5.AnimationSpeed = 0.03F;
            this.gunaGradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton5.BaseColor1 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientButton5.BaseColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.gunaGradientButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton5.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton5.Image")));
            this.gunaGradientButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton5.Location = new System.Drawing.Point(556, 479);
            this.gunaGradientButton5.Name = "gunaGradientButton5";
            this.gunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.Violet;
            this.gunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.OnHoverImage = null;
            this.gunaGradientButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Radius = 10;
            this.gunaGradientButton5.Size = new System.Drawing.Size(126, 40);
            this.gunaGradientButton5.TabIndex = 6;
            this.gunaGradientButton5.Text = "Upload";
            this.gunaGradientButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton5.Click += new System.EventHandler(this.gunaGradientButton5_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.52595F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.72664F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7474F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 400);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // OwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerDashboard";
            this.Text = "OwnerDashboard";
            this.Load += new System.EventHandler(this.OwnerDashboard_Load);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton5;
    }
}
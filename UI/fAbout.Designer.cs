namespace WifiReveal.UI
{
    partial class fAbout
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
            this.tabAbout = new System.Windows.Forms.TabControl();
            this.tabPageThis = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePlugins = new System.Windows.Forms.TabPage();
            this.tabPlugins = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabAbout.SuspendLayout();
            this.tabPageThis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagePlugins.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.tabPageThis);
            this.tabAbout.Controls.Add(this.tabPagePlugins);
            this.tabAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAbout.Location = new System.Drawing.Point(4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.SelectedIndex = 0;
            this.tabAbout.Size = new System.Drawing.Size(336, 242);
            this.tabAbout.TabIndex = 0;
            // 
            // tabPageThis
            // 
            this.tabPageThis.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPageThis.Controls.Add(this.label3);
            this.tabPageThis.Controls.Add(this.linkLabel1);
            this.tabPageThis.Controls.Add(this.label2);
            this.tabPageThis.Controls.Add(this.pictureBox1);
            this.tabPageThis.Controls.Add(this.label1);
            this.tabPageThis.Location = new System.Drawing.Point(4, 22);
            this.tabPageThis.Name = "tabPageThis";
            this.tabPageThis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThis.Size = new System.Drawing.Size(328, 216);
            this.tabPageThis.TabIndex = 0;
            this.tabPageThis.Text = "WifiReveal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor: Reimashi";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pagina web de WifiReveal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0.1.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WifiReveal.Properties.Resources.icon_app_img;
            this.pictureBox1.Location = new System.Drawing.Point(109, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "WifiReveal";
            // 
            // tabPagePlugins
            // 
            this.tabPagePlugins.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPagePlugins.Controls.Add(this.tabPlugins);
            this.tabPagePlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlugins.Name = "tabPagePlugins";
            this.tabPagePlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlugins.Size = new System.Drawing.Size(328, 216);
            this.tabPagePlugins.TabIndex = 1;
            this.tabPagePlugins.Text = "Plugins";
            // 
            // tabPlugins
            // 
            this.tabPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlugins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPlugins.Location = new System.Drawing.Point(3, 3);
            this.tabPlugins.Multiline = true;
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.SelectedIndex = 0;
            this.tabPlugins.Size = new System.Drawing.Size(322, 210);
            this.tabPlugins.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 250);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(260, 6);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Cerrar";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(344, 250);
            this.panel1.TabIndex = 2;
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            this.tabAbout.ResumeLayout(false);
            this.tabPageThis.ResumeLayout(false);
            this.tabPageThis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagePlugins.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAbout;
        private System.Windows.Forms.TabPage tabPageThis;
        private System.Windows.Forms.TabPage tabPagePlugins;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPlugins;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
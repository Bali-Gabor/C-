namespace trafipax
{
    partial class FormFomenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gyorshajtásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rögzítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gyorshajtásokToolStripMenuItem,
            this.statisztikákToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gyorshajtásokToolStripMenuItem
            // 
            this.gyorshajtásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rögzítésToolStripMenuItem});
            this.gyorshajtásokToolStripMenuItem.Name = "gyorshajtásokToolStripMenuItem";
            this.gyorshajtásokToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.gyorshajtásokToolStripMenuItem.Text = "Gyorshajtások";
            // 
            // rögzítésToolStripMenuItem
            // 
            this.rögzítésToolStripMenuItem.Name = "rögzítésToolStripMenuItem";
            this.rögzítésToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.rögzítésToolStripMenuItem.Text = "Rögzítés";
            this.rögzítésToolStripMenuItem.Click += new System.EventHandler(this.rögzítésToolStripMenuItem_Click);
            // 
            // statisztikákToolStripMenuItem
            // 
            this.statisztikákToolStripMenuItem.Name = "statisztikákToolStripMenuItem";
            this.statisztikákToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.statisztikákToolStripMenuItem.Text = "Statisztikák";
            this.statisztikákToolStripMenuItem.Click += new System.EventHandler(this.statisztikákToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // FormFomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gyorshajtásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rögzítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


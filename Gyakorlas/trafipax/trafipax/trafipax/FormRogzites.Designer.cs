namespace trafipax
{
    partial class FormRogzites
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKategória = new System.Windows.Forms.Label();
            this.labelOsszeg = new System.Windows.Forms.Label();
            this.textBoxRendszam = new System.Windows.Forms.TextBox();
            this.textBoxMertSebesseg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sebességhatár: 100 km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mért sebesség:";
            // 
            // labelKategória
            // 
            this.labelKategória.AutoSize = true;
            this.labelKategória.Location = new System.Drawing.Point(47, 167);
            this.labelKategória.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKategória.Name = "labelKategória";
            this.labelKategória.Size = new System.Drawing.Size(52, 17);
            this.labelKategória.TabIndex = 3;
            this.labelKategória.Text = "label4";
            // 
            // labelOsszeg
            // 
            this.labelOsszeg.AutoSize = true;
            this.labelOsszeg.Location = new System.Drawing.Point(342, 167);
            this.labelOsszeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOsszeg.Name = "labelOsszeg";
            this.labelOsszeg.Size = new System.Drawing.Size(52, 17);
            this.labelOsszeg.TabIndex = 4;
            this.labelOsszeg.Text = "label5";
            // 
            // textBoxRendszam
            // 
            this.textBoxRendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRendszam.Location = new System.Drawing.Point(120, 30);
            this.textBoxRendszam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRendszam.Name = "textBoxRendszam";
            this.textBoxRendszam.Size = new System.Drawing.Size(116, 23);
            this.textBoxRendszam.TabIndex = 7;
            // 
            // textBoxMertSebesseg
            // 
            this.textBoxMertSebesseg.Location = new System.Drawing.Point(443, 73);
            this.textBoxMertSebesseg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMertSebesseg.Name = "textBoxMertSebesseg";
            this.textBoxMertSebesseg.Size = new System.Drawing.Size(116, 23);
            this.textBoxMertSebesseg.TabIndex = 8;
            this.textBoxMertSebesseg.TextChanged += new System.EventHandler(this.textBoxMertSebesseg_TextChanged);
            // 
            // button2
            // 
            this.button2.Image = global::trafipax.Properties.Resources.elvet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(379, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Elvetés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::trafipax.Properties.Resources.oke;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(99, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // FormRogzites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMertSebesseg);
            this.Controls.Add(this.textBoxRendszam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.labelKategória);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRogzites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gyorshajtások rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKategória;
        private System.Windows.Forms.Label labelOsszeg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxRendszam;
        private System.Windows.Forms.TextBox textBoxMertSebesseg;
        private System.Windows.Forms.Label label4;
    }
}
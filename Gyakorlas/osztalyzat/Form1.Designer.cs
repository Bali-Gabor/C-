namespace osztalyzat
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.felirat = new System.Windows.Forms.Label();
            this.beolvas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.megjelen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kiszámítás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // felirat
            // 
            this.felirat.AutoSize = true;
            this.felirat.Location = new System.Drawing.Point(12, 9);
            this.felirat.Name = "felirat";
            this.felirat.Size = new System.Drawing.Size(338, 32);
            this.felirat.TabIndex = 1;
            this.felirat.Text = "Add meg a dolgozat eredményét %-ban és kiszámolom\r\naz eredményt.";
            // 
            // beolvas
            // 
            this.beolvas.Location = new System.Drawing.Point(116, 55);
            this.beolvas.Name = "beolvas";
            this.beolvas.Size = new System.Drawing.Size(100, 22);
            this.beolvas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eredmény:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // megjelen
            // 
            this.megjelen.AutoSize = true;
            this.megjelen.Location = new System.Drawing.Point(239, 58);
            this.megjelen.Name = "megjelen";
            this.megjelen.Size = new System.Drawing.Size(0, 16);
            this.megjelen.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 163);
            this.Controls.Add(this.megjelen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beolvas);
            this.Controls.Add(this.felirat);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label felirat;
        private System.Windows.Forms.TextBox beolvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label megjelen;
    }
}


namespace Scuola
{
    partial class AggiungiClassi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSezione = new System.Windows.Forms.ComboBox();
            this.comboBoxAnno = new System.Windows.Forms.ComboBox();
            this.lblSezione = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblAnno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.comboBoxSezione);
            this.panel1.Controls.Add(this.comboBoxAnno);
            this.panel1.Controls.Add(this.lblSezione);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.lblAnno);
            this.panel1.Location = new System.Drawing.Point(115, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxSezione
            // 
            this.comboBoxSezione.FormattingEnabled = true;
            this.comboBoxSezione.Location = new System.Drawing.Point(119, 127);
            this.comboBoxSezione.Name = "comboBoxSezione";
            this.comboBoxSezione.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSezione.TabIndex = 8;
            // 
            // comboBoxAnno
            // 
            this.comboBoxAnno.FormattingEnabled = true;
            this.comboBoxAnno.Location = new System.Drawing.Point(119, 75);
            this.comboBoxAnno.Name = "comboBoxAnno";
            this.comboBoxAnno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnno.TabIndex = 7;
            // 
            // lblSezione
            // 
            this.lblSezione.AutoSize = true;
            this.lblSezione.Location = new System.Drawing.Point(38, 135);
            this.lblSezione.Name = "lblSezione";
            this.lblSezione.Size = new System.Drawing.Size(45, 13);
            this.lblSezione.TabIndex = 6;
            this.lblSezione.Text = "Sezione";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Azure;
            this.btnAggiungi.Location = new System.Drawing.Point(269, 104);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(38, 78);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(32, 13);
            this.lblAnno.TabIndex = 4;
            this.lblAnno.Text = "Anno";
            // 
            // AggiungiClassi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AggiungiClassi";
            this.Text = "AggiungiClassi";
            this.Load += new System.EventHandler(this.AggiungiClassi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSezione;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.ComboBox comboBoxSezione;
        private System.Windows.Forms.ComboBox comboBoxAnno;
    }
}
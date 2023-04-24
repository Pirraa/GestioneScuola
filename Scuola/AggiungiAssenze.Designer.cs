namespace Scuola
{
    partial class AggiungiAssenze
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ckbGiustificato = new System.Windows.Forms.CheckBox();
            this.lblDataFine = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblDataInizio = new System.Windows.Forms.Label();
            this.lblIDstudente = new System.Windows.Forms.Label();
            this.comboBoxStudente = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.comboBoxStudente);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.ckbGiustificato);
            this.panel1.Controls.Add(this.lblDataFine);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.lblMotivo);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.lblDataInizio);
            this.panel1.Controls.Add(this.lblIDstudente);
            this.panel1.Location = new System.Drawing.Point(115, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // ckbGiustificato
            // 
            this.ckbGiustificato.AutoSize = true;
            this.ckbGiustificato.Location = new System.Drawing.Point(122, 166);
            this.ckbGiustificato.Name = "ckbGiustificato";
            this.ckbGiustificato.Size = new System.Drawing.Size(78, 17);
            this.ckbGiustificato.TabIndex = 8;
            this.ckbGiustificato.Text = "Giustificato";
            this.ckbGiustificato.UseVisualStyleBackColor = true;
            // 
            // lblDataFine
            // 
            this.lblDataFine.AutoSize = true;
            this.lblDataFine.Location = new System.Drawing.Point(38, 101);
            this.lblDataFine.Name = "lblDataFine";
            this.lblDataFine.Size = new System.Drawing.Size(61, 13);
            this.lblDataFine.TabIndex = 7;
            this.lblDataFine.Text = "Data di fine";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(122, 140);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(100, 20);
            this.txtMotivo.TabIndex = 3;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(38, 147);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(39, 13);
            this.lblMotivo.TabIndex = 6;
            this.lblMotivo.Text = "Motivo";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Azure;
            this.btnAggiungi.Location = new System.Drawing.Point(147, 209);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblDataInizio
            // 
            this.lblDataInizio.AutoSize = true;
            this.lblDataInizio.Location = new System.Drawing.Point(38, 66);
            this.lblDataInizio.Name = "lblDataInizio";
            this.lblDataInizio.Size = new System.Drawing.Size(67, 13);
            this.lblDataInizio.TabIndex = 5;
            this.lblDataInizio.Text = "Data di inizio";
            // 
            // lblIDstudente
            // 
            this.lblIDstudente.AutoSize = true;
            this.lblIDstudente.Location = new System.Drawing.Point(38, 31);
            this.lblIDstudente.Name = "lblIDstudente";
            this.lblIDstudente.Size = new System.Drawing.Size(59, 13);
            this.lblIDstudente.TabIndex = 4;
            this.lblIDstudente.Text = "IDstudente";
            // 
            // comboBoxStudente
            // 
            this.comboBoxStudente.FormattingEnabled = true;
            this.comboBoxStudente.Location = new System.Drawing.Point(122, 22);
            this.comboBoxStudente.Name = "comboBoxStudente";
            this.comboBoxStudente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudente.TabIndex = 11;
            // 
            // AggiungiAssenze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AggiungiAssenze";
            this.Text = "AggiungiAssenze";
            this.Load += new System.EventHandler(this.AggiungiAssenze_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataFine;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblDataInizio;
        private System.Windows.Forms.Label lblIDstudente;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox ckbGiustificato;
        private System.Windows.Forms.ComboBox comboBoxStudente;
    }
}
namespace Scuola
{
    partial class AggiungiLezione
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
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataFine = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblDataInizio = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.comboBoxDocente = new System.Windows.Forms.ComboBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.comboBoxMateria);
            this.panel1.Controls.Add(this.comboBoxDocente);
            this.panel1.Controls.Add(this.lblDescrizione);
            this.panel1.Controls.Add(this.txtDescrizione);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDataFine);
            this.panel1.Controls.Add(this.lblMateria);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.lblDataInizio);
            this.panel1.Controls.Add(this.lblDocente);
            this.panel1.Location = new System.Drawing.Point(215, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 9;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(38, 173);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(62, 13);
            this.lblDescrizione.TabIndex = 12;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(122, 173);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 20);
            this.txtDescrizione.TabIndex = 11;
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
            // lblDataFine
            // 
            this.lblDataFine.AutoSize = true;
            this.lblDataFine.Location = new System.Drawing.Point(38, 101);
            this.lblDataFine.Name = "lblDataFine";
            this.lblDataFine.Size = new System.Drawing.Size(61, 13);
            this.lblDataFine.TabIndex = 7;
            this.lblDataFine.Text = "Data di fine";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(38, 147);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 6;
            this.lblMateria.Text = "Materia";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Azure;
            this.btnAggiungi.Location = new System.Drawing.Point(156, 203);
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
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(38, 31);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 4;
            this.lblDocente.Text = "Docente";
            // 
            // comboBoxDocente
            // 
            this.comboBoxDocente.FormattingEnabled = true;
            this.comboBoxDocente.Location = new System.Drawing.Point(122, 23);
            this.comboBoxDocente.Name = "comboBoxDocente";
            this.comboBoxDocente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDocente.TabIndex = 13;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(122, 139);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateria.TabIndex = 14;
            // 
            // AggiungiLezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AggiungiLezione";
            this.Text = "AggiungiLezione";
            this.Load += new System.EventHandler(this.AggiungiLezione_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataFine;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblDataInizio;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxDocente;
    }
}
namespace Scuola
{
    partial class AggiungiVoto
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
            this.comboBoxVoto = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.comboBoxDocente = new System.Windows.Forms.ComboBox();
            this.comboBoxStudente = new System.Windows.Forms.ComboBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.lblStudente = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblVoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.comboBoxVoto);
            this.panel1.Controls.Add(this.lblMateria);
            this.panel1.Controls.Add(this.lblDocente);
            this.panel1.Controls.Add(this.comboBoxDocente);
            this.panel1.Controls.Add(this.comboBoxStudente);
            this.panel1.Controls.Add(this.comboBoxMateria);
            this.panel1.Controls.Add(this.lblStudente);
            this.panel1.Controls.Add(this.btnAggiungi);
            this.panel1.Controls.Add(this.lblVoto);
            this.panel1.Location = new System.Drawing.Point(115, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 10;
            // 
            // comboBoxVoto
            // 
            this.comboBoxVoto.FormattingEnabled = true;
            this.comboBoxVoto.Location = new System.Drawing.Point(139, 47);
            this.comboBoxVoto.Name = "comboBoxVoto";
            this.comboBoxVoto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVoto.TabIndex = 12;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(55, 130);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 11;
            this.lblMateria.Text = "Materia";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(55, 172);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 10;
            this.lblDocente.Text = "Docente";
            // 
            // comboBoxDocente
            // 
            this.comboBoxDocente.FormattingEnabled = true;
            this.comboBoxDocente.Location = new System.Drawing.Point(139, 164);
            this.comboBoxDocente.Name = "comboBoxDocente";
            this.comboBoxDocente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDocente.TabIndex = 9;
            // 
            // comboBoxStudente
            // 
            this.comboBoxStudente.FormattingEnabled = true;
            this.comboBoxStudente.Location = new System.Drawing.Point(139, 86);
            this.comboBoxStudente.Name = "comboBoxStudente";
            this.comboBoxStudente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudente.TabIndex = 8;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(139, 127);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateria.TabIndex = 7;
            // 
            // lblStudente
            // 
            this.lblStudente.AutoSize = true;
            this.lblStudente.Location = new System.Drawing.Point(55, 86);
            this.lblStudente.Name = "lblStudente";
            this.lblStudente.Size = new System.Drawing.Size(50, 13);
            this.lblStudente.TabIndex = 6;
            this.lblStudente.Text = "Studente";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Azure;
            this.btnAggiungi.Location = new System.Drawing.Point(280, 105);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Location = new System.Drawing.Point(55, 50);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(29, 13);
            this.lblVoto.TabIndex = 4;
            this.lblVoto.Text = "Voto";
            // 
            // AggiungiVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AggiungiVoto";
            this.Text = "AggiungiVoto";
            this.Load += new System.EventHandler(this.AggiungiVoto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudente;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.ComboBox comboBoxDocente;
        private System.Windows.Forms.ComboBox comboBoxStudente;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox comboBoxVoto;
    }
}
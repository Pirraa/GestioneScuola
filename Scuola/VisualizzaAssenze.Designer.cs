
namespace Scuola
{
    partial class VisualizzaAssenze
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
            this.dataGridViewAssenze = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giustificato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssenze)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssenze
            // 
            this.dataGridViewAssenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssenze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.studente,
            this.data_inizio,
            this.data_fine,
            this.giustificato,
            this.motivazione});
            this.dataGridViewAssenze.Location = new System.Drawing.Point(49, 51);
            this.dataGridViewAssenze.Name = "dataGridViewAssenze";
            this.dataGridViewAssenze.Size = new System.Drawing.Size(702, 348);
            this.dataGridViewAssenze.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // studente
            // 
            this.studente.HeaderText = "Studente";
            this.studente.Name = "studente";
            // 
            // data_inizio
            // 
            this.data_inizio.HeaderText = "Data Inizio";
            this.data_inizio.Name = "data_inizio";
            // 
            // data_fine
            // 
            this.data_fine.HeaderText = "Data Fine";
            this.data_fine.Name = "data_fine";
            // 
            // giustificato
            // 
            this.giustificato.HeaderText = "Giustificato";
            this.giustificato.Name = "giustificato";
            // 
            // motivazione
            // 
            this.motivazione.HeaderText = "Motivazione";
            this.motivazione.Name = "motivazione";
            // 
            // VisualizzaAssenze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAssenze);
            this.Name = "VisualizzaAssenze";
            this.Text = "VisualizzaAssenze";
            this.Load += new System.EventHandler(this.VisualizzaAssenze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssenze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssenze;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_inizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn giustificato;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivazione;
    }
}
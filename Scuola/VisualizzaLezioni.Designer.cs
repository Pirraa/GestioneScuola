
namespace Scuola
{
    partial class VisualizzaLezioni
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
            this.dataGridViewLezioni = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argomento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLezioni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLezioni
            // 
            this.dataGridViewLezioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLezioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data_inizio,
            this.data_fine,
            this.docente,
            this.materia,
            this.argomento});
            this.dataGridViewLezioni.Location = new System.Drawing.Point(38, 56);
            this.dataGridViewLezioni.Name = "dataGridViewLezioni";
            this.dataGridViewLezioni.Size = new System.Drawing.Size(702, 336);
            this.dataGridViewLezioni.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
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
            // docente
            // 
            this.docente.HeaderText = "Docente";
            this.docente.Name = "docente";
            // 
            // materia
            // 
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            // 
            // argomento
            // 
            this.argomento.HeaderText = "Argomento";
            this.argomento.Name = "argomento";
            // 
            // VisualizzaLezioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLezioni);
            this.Name = "VisualizzaLezioni";
            this.Text = "VisualizzaLezioni";
            this.Load += new System.EventHandler(this.VisualizzaLezioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLezioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLezioni;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_inizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn argomento;
    }
}
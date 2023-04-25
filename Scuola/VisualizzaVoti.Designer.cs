
namespace Scuola
{
    partial class VisualizzaVoti
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
            this.dataGridViewVoti = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVoti
            // 
            this.dataGridViewVoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.studente,
            this.docente,
            this.materia,
            this.voto});
            this.dataGridViewVoti.Location = new System.Drawing.Point(28, 51);
            this.dataGridViewVoti.Name = "dataGridViewVoti";
            this.dataGridViewVoti.Size = new System.Drawing.Size(724, 365);
            this.dataGridViewVoti.TabIndex = 3;
            this.dataGridViewVoti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewVoti_KeyDown_1);
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
            // voto
            // 
            this.voto.HeaderText = "Voto";
            this.voto.Name = "voto";
            // 
            // VisualizzaVoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVoti);
            this.Name = "VisualizzaVoti";
            this.Text = "VisualizzaVoti";
            this.Load += new System.EventHandler(this.VisualizzaVoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVoti;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studente;
        private System.Windows.Forms.DataGridViewTextBoxColumn docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn voto;
    }
}
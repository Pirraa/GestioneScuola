
namespace Scuola
{
    partial class VisualizzaClassi
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
            this.dataGridViewClassi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sezione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClassi
            // 
            this.dataGridViewClassi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sezione,
            this.anno});
            this.dataGridViewClassi.Location = new System.Drawing.Point(43, 55);
            this.dataGridViewClassi.Name = "dataGridViewClassi";
            this.dataGridViewClassi.Size = new System.Drawing.Size(702, 348);
            this.dataGridViewClassi.TabIndex = 3;
            this.dataGridViewClassi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewClassi_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // sezione
            // 
            this.sezione.HeaderText = "Sezione";
            this.sezione.Name = "sezione";
            // 
            // anno
            // 
            this.anno.HeaderText = "Anno";
            this.anno.Name = "anno";
            // 
            // VisualizzaClassi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewClassi);
            this.Name = "VisualizzaClassi";
            this.Text = "VisualizzaClassi";
            this.Load += new System.EventHandler(this.VisualizzaClassi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sezione;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
    }
}
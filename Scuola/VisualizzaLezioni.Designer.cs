
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLezioni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLezioni
            // 
            this.dataGridViewLezioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLezioni.Location = new System.Drawing.Point(38, 56);
            this.dataGridViewLezioni.Name = "dataGridViewLezioni";
            this.dataGridViewLezioni.Size = new System.Drawing.Size(702, 336);
            this.dataGridViewLezioni.TabIndex = 3;
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
    }
}
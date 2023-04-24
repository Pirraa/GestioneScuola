
namespace Scuola
{
    partial class VisualizzaMaterie
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
            this.dataGridViewMaterie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterie
            // 
            this.dataGridViewMaterie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterie.Location = new System.Drawing.Point(32, 46);
            this.dataGridViewMaterie.Name = "dataGridViewMaterie";
            this.dataGridViewMaterie.Size = new System.Drawing.Size(726, 340);
            this.dataGridViewMaterie.TabIndex = 3;
            // 
            // VisualizzaMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMaterie);
            this.Name = "VisualizzaMaterie";
            this.Text = "VisualizzaMaterie";
            this.Load += new System.EventHandler(this.VisualizzaMaterie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaterie;
    }
}
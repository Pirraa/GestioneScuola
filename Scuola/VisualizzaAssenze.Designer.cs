
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssenze)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssenze
            // 
            this.dataGridViewAssenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssenze.Location = new System.Drawing.Point(49, 51);
            this.dataGridViewAssenze.Name = "dataGridViewAssenze";
            this.dataGridViewAssenze.Size = new System.Drawing.Size(702, 348);
            this.dataGridViewAssenze.TabIndex = 4;
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
    }
}
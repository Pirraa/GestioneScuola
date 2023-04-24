
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClassi
            // 
            this.dataGridViewClassi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassi.Location = new System.Drawing.Point(43, 55);
            this.dataGridViewClassi.Name = "dataGridViewClassi";
            this.dataGridViewClassi.Size = new System.Drawing.Size(702, 348);
            this.dataGridViewClassi.TabIndex = 3;
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
    }
}
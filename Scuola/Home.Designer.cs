namespace Scuola
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assenzeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assenzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewStudenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewDocenti = new System.Windows.Forms.DataGridView();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.lblDocenti = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocenti)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aggiungiStudenteToolStripMenuItem,
            this.visualizzaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // aggiungiStudenteToolStripMenuItem
            // 
            this.aggiungiStudenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studenteToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.votiToolStripMenuItem1,
            this.assenzeToolStripMenuItem1,
            this.lezioniToolStripMenuItem1,
            this.classiToolStripMenuItem,
            this.materieToolStripMenuItem});
            this.aggiungiStudenteToolStripMenuItem.Name = "aggiungiStudenteToolStripMenuItem";
            this.aggiungiStudenteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aggiungiStudenteToolStripMenuItem.Text = "Aggiungi";
            // 
            // studenteToolStripMenuItem
            // 
            this.studenteToolStripMenuItem.Name = "studenteToolStripMenuItem";
            this.studenteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.studenteToolStripMenuItem.Text = "Studente";
            this.studenteToolStripMenuItem.Click += new System.EventHandler(this.studenteToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // votiToolStripMenuItem1
            // 
            this.votiToolStripMenuItem1.Name = "votiToolStripMenuItem1";
            this.votiToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.votiToolStripMenuItem1.Text = "Voti";
            this.votiToolStripMenuItem1.Click += new System.EventHandler(this.votiToolStripMenuItem1_Click);
            // 
            // assenzeToolStripMenuItem1
            // 
            this.assenzeToolStripMenuItem1.Name = "assenzeToolStripMenuItem1";
            this.assenzeToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.assenzeToolStripMenuItem1.Text = "Assenze";
            this.assenzeToolStripMenuItem1.Click += new System.EventHandler(this.assenzeToolStripMenuItem1_Click);
            // 
            // lezioniToolStripMenuItem1
            // 
            this.lezioniToolStripMenuItem1.Name = "lezioniToolStripMenuItem1";
            this.lezioniToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.lezioniToolStripMenuItem1.Text = "Lezioni";
            this.lezioniToolStripMenuItem1.Click += new System.EventHandler(this.lezioniToolStripMenuItem1_Click);
            // 
            // classiToolStripMenuItem
            // 
            this.classiToolStripMenuItem.Name = "classiToolStripMenuItem";
            this.classiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.classiToolStripMenuItem.Text = "Classi";
            this.classiToolStripMenuItem.Click += new System.EventHandler(this.classiToolStripMenuItem_Click);
            // 
            // materieToolStripMenuItem
            // 
            this.materieToolStripMenuItem.Name = "materieToolStripMenuItem";
            this.materieToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.materieToolStripMenuItem.Text = "Materie";
            this.materieToolStripMenuItem.Click += new System.EventHandler(this.materieToolStripMenuItem_Click);
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votiToolStripMenuItem,
            this.assenzeToolStripMenuItem,
            this.lezioniToolStripMenuItem,
            this.classiToolStripMenuItem1,
            this.materieToolStripMenuItem1});
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // votiToolStripMenuItem
            // 
            this.votiToolStripMenuItem.Name = "votiToolStripMenuItem";
            this.votiToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.votiToolStripMenuItem.Text = "Voti";
            this.votiToolStripMenuItem.Click += new System.EventHandler(this.votiToolStripMenuItem_Click);
            // 
            // assenzeToolStripMenuItem
            // 
            this.assenzeToolStripMenuItem.Name = "assenzeToolStripMenuItem";
            this.assenzeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.assenzeToolStripMenuItem.Text = "Assenze";
            this.assenzeToolStripMenuItem.Click += new System.EventHandler(this.assenzeToolStripMenuItem_Click);
            // 
            // lezioniToolStripMenuItem
            // 
            this.lezioniToolStripMenuItem.Name = "lezioniToolStripMenuItem";
            this.lezioniToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.lezioniToolStripMenuItem.Text = "Lezioni";
            this.lezioniToolStripMenuItem.Click += new System.EventHandler(this.lezioniToolStripMenuItem_Click);
            // 
            // classiToolStripMenuItem1
            // 
            this.classiToolStripMenuItem1.Name = "classiToolStripMenuItem1";
            this.classiToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.classiToolStripMenuItem1.Text = "Classi";
            this.classiToolStripMenuItem1.Click += new System.EventHandler(this.classiToolStripMenuItem1_Click);
            // 
            // materieToolStripMenuItem1
            // 
            this.materieToolStripMenuItem1.Name = "materieToolStripMenuItem1";
            this.materieToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.materieToolStripMenuItem1.Text = "Materie";
            this.materieToolStripMenuItem1.Click += new System.EventHandler(this.materieToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logoutToolStripMenuItem.Text = "Log-out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dataGridViewStudenti
            // 
            this.dataGridViewStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudenti.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewStudenti.Name = "dataGridViewStudenti";
            this.dataGridViewStudenti.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewStudenti.TabIndex = 2;
            this.dataGridViewStudenti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStudenti_KeyDown);
            // 
            // dataGridViewDocenti
            // 
            this.dataGridViewDocenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocenti.Location = new System.Drawing.Point(0, 217);
            this.dataGridViewDocenti.Name = "dataGridViewDocenti";
            this.dataGridViewDocenti.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewDocenti.TabIndex = 3;
            this.dataGridViewDocenti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDocenti_KeyDown);
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Location = new System.Drawing.Point(12, 27);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(95, 13);
            this.lblStudenti.TabIndex = 4;
            this.lblStudenti.Text = "Visualizza Studenti";
            // 
            // lblDocenti
            // 
            this.lblDocenti.AutoSize = true;
            this.lblDocenti.Location = new System.Drawing.Point(12, 201);
            this.lblDocenti.Name = "lblDocenti";
            this.lblDocenti.Size = new System.Drawing.Size(93, 13);
            this.lblDocenti.TabIndex = 5;
            this.lblDocenti.Text = "Visualizza Docenti";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblDocenti);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.dataGridViewDocenti);
            this.Controls.Add(this.dataGridViewStudenti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assenzeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem votiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assenzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lezioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lezioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materieToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewStudenti;
        private System.Windows.Forms.DataGridView dataGridViewDocenti;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.Label lblDocenti;
    }
}
namespace GestionaleUI.FrontEnd
{
    partial class ModificaPaziente
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeRicerca = new System.Windows.Forms.TextBox();
            this.txtCognomeRicerca = new System.Windows.Forms.TextBox();
            this.txtCFRicerca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPazienti = new System.Windows.Forms.DataGridView();
            this.dataGridViewPiani = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiani)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridViewPiani);
            this.panel1.Controls.Add(this.dataGridViewPazienti);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCFRicerca);
            this.panel1.Controls.Add(this.txtCognomeRicerca);
            this.panel1.Controls.Add(this.txtNomeRicerca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 587);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice Fiscale:";
            // 
            // txtNomeRicerca
            // 
            this.txtNomeRicerca.Location = new System.Drawing.Point(287, 51);
            this.txtNomeRicerca.Name = "txtNomeRicerca";
            this.txtNomeRicerca.Size = new System.Drawing.Size(100, 22);
            this.txtNomeRicerca.TabIndex = 3;
            // 
            // txtCognomeRicerca
            // 
            this.txtCognomeRicerca.Location = new System.Drawing.Point(474, 51);
            this.txtCognomeRicerca.Name = "txtCognomeRicerca";
            this.txtCognomeRicerca.Size = new System.Drawing.Size(100, 22);
            this.txtCognomeRicerca.TabIndex = 4;
            // 
            // txtCFRicerca
            // 
            this.txtCFRicerca.Location = new System.Drawing.Point(685, 51);
            this.txtCFRicerca.Name = "txtCFRicerca";
            this.txtCFRicerca.Size = new System.Drawing.Size(183, 22);
            this.txtCFRicerca.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // dataGridViewPazienti
            // 
            this.dataGridViewPazienti.AllowUserToOrderColumns = true;
            this.dataGridViewPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPazienti.Location = new System.Drawing.Point(34, 103);
            this.dataGridViewPazienti.Name = "dataGridViewPazienti";
            this.dataGridViewPazienti.RowTemplate.Height = 24;
            this.dataGridViewPazienti.Size = new System.Drawing.Size(569, 680);
            this.dataGridViewPazienti.TabIndex = 7;
            this.dataGridViewPazienti.SelectionChanged += new System.EventHandler(this.dataGridViewPazienti_SelectionChanged);
            // 
            // dataGridViewPiani
            // 
            this.dataGridViewPiani.AllowUserToOrderColumns = true;
            this.dataGridViewPiani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiani.Location = new System.Drawing.Point(609, 103);
            this.dataGridViewPiani.Name = "dataGridViewPiani";
            this.dataGridViewPiani.RowTemplate.Height = 24;
            this.dataGridViewPiani.Size = new System.Drawing.Size(584, 680);
            this.dataGridViewPiani.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1023, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // ModificaPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ModificaPaziente";
            this.Size = new System.Drawing.Size(1218, 589);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCFRicerca;
        private System.Windows.Forms.TextBox txtCognomeRicerca;
        private System.Windows.Forms.TextBox txtNomeRicerca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPazienti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPiani;
        private System.Windows.Forms.Button button2;
    }
}

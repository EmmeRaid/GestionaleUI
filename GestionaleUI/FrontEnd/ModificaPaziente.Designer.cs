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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewPiani = new System.Windows.Forms.DataGridView();
            this.dataGridViewPazienti = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCFRicerca = new System.Windows.Forms.TextBox();
            this.txtCognomeRicerca = new System.Windows.Forms.TextBox();
            this.txtNomeRicerca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 477);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // dataGridViewPiani
            // 
            this.dataGridViewPiani.AllowUserToOrderColumns = true;
            this.dataGridViewPiani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiani.Location = new System.Drawing.Point(457, 84);
            this.dataGridViewPiani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPiani.Name = "dataGridViewPiani";
            this.dataGridViewPiani.RowTemplate.Height = 24;
            this.dataGridViewPiani.Size = new System.Drawing.Size(438, 552);
            this.dataGridViewPiani.TabIndex = 8;
            // 
            // dataGridViewPazienti
            // 
            this.dataGridViewPazienti.AllowUserToOrderColumns = true;
            this.dataGridViewPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPazienti.Location = new System.Drawing.Point(26, 84);
            this.dataGridViewPazienti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPazienti.Name = "dataGridViewPazienti";
            this.dataGridViewPazienti.RowTemplate.Height = 24;
            this.dataGridViewPazienti.Size = new System.Drawing.Size(427, 552);
            this.dataGridViewPazienti.TabIndex = 7;
            this.dataGridViewPazienti.SelectionChanged += new System.EventHandler(this.dataGridViewPazienti_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // txtCFRicerca
            // 
            this.txtCFRicerca.Location = new System.Drawing.Point(514, 41);
            this.txtCFRicerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCFRicerca.Name = "txtCFRicerca";
            this.txtCFRicerca.Size = new System.Drawing.Size(138, 20);
            this.txtCFRicerca.TabIndex = 5;
            // 
            // txtCognomeRicerca
            // 
            this.txtCognomeRicerca.Location = new System.Drawing.Point(356, 41);
            this.txtCognomeRicerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCognomeRicerca.Name = "txtCognomeRicerca";
            this.txtCognomeRicerca.Size = new System.Drawing.Size(76, 20);
            this.txtCognomeRicerca.TabIndex = 4;
            // 
            // txtNomeRicerca
            // 
            this.txtNomeRicerca.Location = new System.Drawing.Point(215, 41);
            this.txtNomeRicerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeRicerca.Name = "txtNomeRicerca";
            this.txtNomeRicerca.Size = new System.Drawing.Size(76, 20);
            this.txtNomeRicerca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice Fiscale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // ModificaPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificaPaziente";
            this.Size = new System.Drawing.Size(914, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).EndInit();
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

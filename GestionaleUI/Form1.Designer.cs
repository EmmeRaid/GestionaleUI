namespace GestionaleUI
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Esci = new System.Windows.Forms.Button();
            this.StampaUtenti = new System.Windows.Forms.Button();
            this.EliminaUtente = new System.Windows.Forms.Button();
            this.ModificaUtente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AggiungiUtente = new System.Windows.Forms.Button();
            this.panelContenuto = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMenu.Controls.Add(this.tableLayoutPanel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 633);
            this.PanelMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Esci, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.StampaUtenti, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EliminaUtente, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ModificaUtente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AggiungiUtente, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Esci
            // 
            this.Esci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Esci.BackColor = System.Drawing.Color.Transparent;
            this.Esci.ForeColor = System.Drawing.Color.Black;
            this.Esci.Location = new System.Drawing.Point(40, 249);
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(120, 23);
            this.Esci.TabIndex = 5;
            this.Esci.Text = "Esci";
            this.Esci.UseVisualStyleBackColor = false;
            this.Esci.Click += new System.EventHandler(this.Esci_Click);
            // 
            // StampaUtenti
            // 
            this.StampaUtenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StampaUtenti.Location = new System.Drawing.Point(40, 200);
            this.StampaUtenti.Name = "StampaUtenti";
            this.StampaUtenti.Size = new System.Drawing.Size(120, 23);
            this.StampaUtenti.TabIndex = 4;
            this.StampaUtenti.Text = "Stampa Pazienti";
            this.StampaUtenti.UseVisualStyleBackColor = true;
            // 
            // EliminaUtente
            // 
            this.EliminaUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EliminaUtente.Location = new System.Drawing.Point(40, 153);
            this.EliminaUtente.Name = "EliminaUtente";
            this.EliminaUtente.Size = new System.Drawing.Size(120, 23);
            this.EliminaUtente.TabIndex = 3;
            this.EliminaUtente.Text = "Elimina Paziente";
            this.EliminaUtente.UseVisualStyleBackColor = true;
            this.EliminaUtente.Click += new System.EventHandler(this.EliminaUtente_Click);
            // 
            // ModificaUtente
            // 
            this.ModificaUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModificaUtente.Location = new System.Drawing.Point(40, 106);
            this.ModificaUtente.Name = "ModificaUtente";
            this.ModificaUtente.Size = new System.Drawing.Size(120, 23);
            this.ModificaUtente.TabIndex = 2;
            this.ModificaUtente.Text = "Modifica Paziente";
            this.ModificaUtente.UseVisualStyleBackColor = true;
            this.ModificaUtente.Click += new System.EventHandler(this.ModificaUtente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // AggiungiUtente
            // 
            this.AggiungiUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AggiungiUtente.Location = new System.Drawing.Point(40, 59);
            this.AggiungiUtente.Name = "AggiungiUtente";
            this.AggiungiUtente.Size = new System.Drawing.Size(120, 23);
            this.AggiungiUtente.TabIndex = 1;
            this.AggiungiUtente.Text = "Aggiungi Paziente";
            this.AggiungiUtente.UseVisualStyleBackColor = true;
            this.AggiungiUtente.Click += new System.EventHandler(this.AggiungiUtente_Click);
            // 
            // panelContenuto
            // 
            this.panelContenuto.Location = new System.Drawing.Point(203, 0);
            this.panelContenuto.Name = "panelContenuto";
            this.panelContenuto.Size = new System.Drawing.Size(984, 633);
            this.panelContenuto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 633);
            this.Controls.Add(this.panelContenuto);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Esci;
        private System.Windows.Forms.Button StampaUtenti;
        private System.Windows.Forms.Button EliminaUtente;
        private System.Windows.Forms.Button ModificaUtente;
        private System.Windows.Forms.Button AggiungiUtente;
        private System.Windows.Forms.Panel panelContenuto;
    }
}


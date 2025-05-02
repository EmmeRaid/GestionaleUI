namespace GestionaleUI.FrontEnd
{
    partial class StampaPazienti
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmacoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inizioPianoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finePianoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pazienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pazienteStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pazienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pazienteStoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteStoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteStoreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.codiceFiscaleDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.farmacoDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.inizioPianoDataGridViewTextBoxColumn,
            this.finePianoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pazienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 620);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codiceFiscaleDataGridViewTextBoxColumn
            // 
            this.codiceFiscaleDataGridViewTextBoxColumn.DataPropertyName = "CodiceFiscale";
            this.codiceFiscaleDataGridViewTextBoxColumn.HeaderText = "CodiceFiscale";
            this.codiceFiscaleDataGridViewTextBoxColumn.Name = "codiceFiscaleDataGridViewTextBoxColumn";
            this.codiceFiscaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // farmacoDataGridViewTextBoxColumn
            // 
            this.farmacoDataGridViewTextBoxColumn.DataPropertyName = "Farmaco";
            this.farmacoDataGridViewTextBoxColumn.HeaderText = "Farmaco";
            this.farmacoDataGridViewTextBoxColumn.Name = "farmacoDataGridViewTextBoxColumn";
            this.farmacoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inizioPianoDataGridViewTextBoxColumn
            // 
            this.inizioPianoDataGridViewTextBoxColumn.DataPropertyName = "InizioPiano";
            this.inizioPianoDataGridViewTextBoxColumn.HeaderText = "InizioPiano";
            this.inizioPianoDataGridViewTextBoxColumn.Name = "inizioPianoDataGridViewTextBoxColumn";
            this.inizioPianoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finePianoDataGridViewTextBoxColumn
            // 
            this.finePianoDataGridViewTextBoxColumn.DataPropertyName = "FinePiano";
            this.finePianoDataGridViewTextBoxColumn.HeaderText = "FinePiano";
            this.finePianoDataGridViewTextBoxColumn.Name = "finePianoDataGridViewTextBoxColumn";
            this.finePianoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pazienteBindingSource
            // 
            this.pazienteBindingSource.DataSource = typeof(GestionaleUI.BackEnd.Paziente);
            // 
            // pazienteBindingSource2
            // 
            this.pazienteBindingSource2.DataSource = typeof(GestionaleUI.BackEnd.Paziente);
            // 
            // pazienteStoreBindingSource
            // 
            this.pazienteStoreBindingSource.DataSource = typeof(GestionaleUI.BackEnd.PazienteStore);
            // 
            // pazienteBindingSource1
            // 
            this.pazienteBindingSource1.DataSource = typeof(GestionaleUI.BackEnd.Paziente);
            // 
            // pazienteStoreBindingSource1
            // 
            this.pazienteStoreBindingSource1.DataSource = typeof(GestionaleUI.BackEnd.PazienteStore);
            // 
            // StampaPazienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "StampaPazienti";
            this.Size = new System.Drawing.Size(964, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteStoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazienteStoreBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pazienteBindingSource;
        private System.Windows.Forms.BindingSource pazienteStoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmacoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inizioPianoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finePianoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pazienteBindingSource2;
        private System.Windows.Forms.BindingSource pazienteBindingSource1;
        private System.Windows.Forms.BindingSource pazienteStoreBindingSource1;
    }
}

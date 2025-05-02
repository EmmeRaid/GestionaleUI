using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionaleUI.BackEnd;

namespace GestionaleUI.FrontEnd
{
    public partial class AggiungiPazienti : UserControl
    {
        public AggiungiPazienti()
        {
            InitializeComponent();
            PazienteStore.CaricaDaFile();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cognome = txtCognome.Text.Trim();
            string codiceFiscale = txtCF.Text.Trim();
            string farmaco = txtFarmaco.Text.Trim();

            DateTime dataNascita = dateTimePickerNascita.Value;
            DateTime dataInizioPiano = dateTimePickerInizio.Value;
            DateTime dataFinePiano = dateTimePickerFine.Value;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cognome) &&
                !string.IsNullOrWhiteSpace(codiceFiscale) &&
                !string.IsNullOrWhiteSpace(farmaco))
            {
                var paziente = new Paziente(nome, cognome, codiceFiscale, dataNascita, farmaco, dataInizioPiano, dataFinePiano);
                PazienteStore.Aggiungi(paziente);
                PazienteStore.SalvaSuFile(); // Usa il percorso centralizzato
                MessageBox.Show("Paziente salvato con successo!");

                // Pulizia dei campi
                txtNome.Clear();
                txtCognome.Clear();
                txtCF.Clear();
                txtFarmaco.Clear();
                dateTimePickerNascita.Value = DateTime.Today;
                dateTimePickerInizio.Value = DateTime.Today;
                dateTimePickerFine.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

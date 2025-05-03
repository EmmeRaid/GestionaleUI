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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cognome = txtCognome.Text.Trim();
            string codiceFiscale = txtCF.Text.Trim();
            string farmaco = txtFarmaco.Text.Trim();
            string dosaggio = txtDosaggio.Text.Trim(); // Aggiunto per il dosaggio

            DateTime dataNascita = dateTimePickerNascita.Value;
            DateTime dataInizioPiano = dateTimePickerInizio.Value;
            DateTime dataFinePiano = dateTimePickerFine.Value;

            if (!string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(cognome) &&
                !string.IsNullOrWhiteSpace(codiceFiscale) &&
                !string.IsNullOrWhiteSpace(farmaco))
            {
                // Cerca se esiste già un paziente con lo stesso Codice Fiscale
                var pazienteEsistente = PazienteStore.ListaPazienti.FirstOrDefault(p => p.CodiceFiscale == codiceFiscale);

                if (pazienteEsistente != null)
                {
                    // Se il paziente esiste già, aggiungi il piano
                    var piano = new PianoTerapeutico(farmaco, dataInizioPiano, dataFinePiano, dosaggio);
                    pazienteEsistente.AggiungiPiano(piano);
                    PazienteStore.SalvaSuFile(); // Salva tutto su file JSON
                    MessageBox.Show("Piano aggiunto al paziente esistente!");
                }
                else
                {
                    // Se il paziente non esiste, crealo
                    var paziente = new Paziente(nome, cognome, codiceFiscale, dataNascita);

                    // Crea il piano e aggiungilo al nuovo paziente
                    var piano = new PianoTerapeutico(farmaco, dataInizioPiano, dataFinePiano, dosaggio);
                    paziente.AggiungiPiano(piano);

                    PazienteStore.Aggiungi(paziente); // Aggiungi il nuovo paziente alla lista
                    PazienteStore.SalvaSuFile(); // Salva tutto su file JSON
                    MessageBox.Show("Paziente salvato con successo!");
                }
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Puoi lasciare questo vuoto o implementarlo come necessario
        }
    }
}

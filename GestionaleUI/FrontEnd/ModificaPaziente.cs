using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionaleUI.BackEnd;

namespace GestionaleUI.FrontEnd
{
    public partial class ModificaPaziente : UserControl
    {
        public ModificaPaziente()
        {
            InitializeComponent();
        }

        private Paziente pazienteSelezionato;

        // Metodo per cercare i pazienti
        private void btnCerca_Click(object sender, EventArgs e)
        {
            string nome = txtNomeRicerca.Text.Trim().ToLower();
            string cognome = txtCognomeRicerca.Text.Trim().ToLower();
            string cf = txtCFRicerca.Text.Trim().ToLower();

            var risultati = PazienteStore.GetAll().Where(p =>
                (string.IsNullOrWhiteSpace(nome) || p.Nome.ToLower().Contains(nome)) &&
                (string.IsNullOrWhiteSpace(cognome) || p.Cognome.ToLower().Contains(cognome)) &&
                (string.IsNullOrWhiteSpace(cf) || p.CodiceFiscale.ToLower().Contains(cf))
            ).ToList();

            // Se non ci sono risultati, mostra un messaggio
            if (risultati.Count == 0)
            {
                MessageBox.Show("Nessun paziente trovato con i criteri di ricerca specificati.");
                return;
            }

            // Ricarica il DataGridView con i risultati della ricerca
            dataGridViewPazienti.DataSource = null;
            dataGridViewPazienti.DataSource = risultati;
        }

        // Classe per rappresentare una riga del piano terapeutico esteso
        private class RigaPianoEsteso
        {
            public string Farmaco { get; set; }
            public string Dosaggio { get; set; }
            public DateTime Inizio { get; set; }
            public DateTime Fine { get; set; }
        }

        // Evento quando viene selezionata una riga nel DataGridView dei pazienti
        private void dataGridViewPazienti_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPazienti.SelectedRows.Count > 0)
            {
                pazienteSelezionato = (Paziente)dataGridViewPazienti.SelectedRows[0].DataBoundItem;

                // txtNomeRicerca.Text = pazienteSelezionato.Nome;
                // txtCognomeRicerca.Text = pazienteSelezionato.Cognome; RIEMPIMENTO NON NECESSARIO
                // txtCFRicerca.Text = pazienteSelezionato.CodiceFiscale;

                var righePiani = pazienteSelezionato.Piani.Select(p => new RigaPianoEsteso
                {
                    Farmaco = p.Farmaco,
                    Dosaggio = p.Dosaggio,
                    Inizio = p.Inizio,
                    Fine = p.Fine
                }).ToList();

                dataGridViewPiani.DataSource = null;
                dataGridViewPiani.DataSource = righePiani;
            }
        }

        // Metodo per salvare i dati modificati
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                if (pazienteSelezionato != null)
                {
                    // Aggiorna i dati del paziente selezionato con quelli modificati nelle celle del DataGridViewPazienti
                    foreach (DataGridViewRow row in dataGridViewPazienti.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // Se la riga corrisponde al paziente selezionato, aggiorna i dati
                        if (row.Cells["CodiceFiscale"].Value?.ToString() == pazienteSelezionato.CodiceFiscale)
                        {
                            // Controllo per assicurarsi che le celle contengano valori validi
                            pazienteSelezionato.Nome = row.Cells["Nome"].Value?.ToString() ?? pazienteSelezionato.Nome;
                            pazienteSelezionato.Cognome = row.Cells["Cognome"].Value?.ToString() ?? pazienteSelezionato.Cognome;
                            pazienteSelezionato.CodiceFiscale = row.Cells["CodiceFiscale"].Value?.ToString() ?? pazienteSelezionato.CodiceFiscale;

                            // Verifica se la Data di Nascita è valida
                            if (row.Cells["DataNascita"].Value != null && DateTime.TryParse(row.Cells["DataNascita"].Value?.ToString(), out DateTime dataNascita))
                            {
                                pazienteSelezionato.DataNascita = dataNascita;
                            }

                            break;
                        }
                    }

                    // Ora aggiorniamo i piani terapeutici direttamente dal DataGridViewPiani
                    var pianiModificati = new List<PianoTerapeutico>();

                    foreach (DataGridViewRow row in dataGridViewPiani.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // Controllo per valori non nulli nelle celle
                        if (row.Cells["Farmaco"].Value != null && row.Cells["Inizio"].Value != null && row.Cells["Fine"].Value != null && row.Cells["Dosaggio"].Value != null)
                        {
                            pianiModificati.Add(new PianoTerapeutico(
                                row.Cells["Farmaco"].Value?.ToString(),    // Farmaco
                                (DateTime)row.Cells["Inizio"].Value,       // Inizio
                                (DateTime)row.Cells["Fine"].Value,         // Fine
                                row.Cells["Dosaggio"].Value?.ToString()    // Dosaggio
                            ));
                        }
                        else
                        {
                            MessageBox.Show("Controlla che tutti i campi del piano terapeutico siano compilati correttamente.");
                            return;
                        }
                    }

                    // Aggiorna i piani del paziente selezionato
                    pazienteSelezionato.Piani = pianiModificati;

                    // Dopo aver aggiornato l'oggetto paziente, assicurati di aggiornare la lista dei pazienti in memoria
                    PazienteStore.SalvaSuFile(); // Salva su file JSON

                    MessageBox.Show("Paziente aggiornato con successo!");

                    // **Ecco la modifica per mantenere la selezione o la ricerca**
                    if (txtNomeRicerca.Text.Trim().Length > 0 || txtCognomeRicerca.Text.Trim().Length > 0 || txtCFRicerca.Text.Trim().Length > 0)
                    {
                        // Se è stata fatta una ricerca, ricarica i risultati della ricerca
                        btnCerca_Click(sender, e);
                    }
                    else
                    {
                        // Altrimenti, ricarica solo il paziente modificato
                        dataGridViewPazienti.DataSource = new List<Paziente> { pazienteSelezionato };
                    }
                }
                else
                {
                    MessageBox.Show("Seleziona un paziente da modificare.");
                }
            }
            catch (Exception ex)
            {
                // Aggiungi un messaggio di errore per capire cosa è andato storto
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }


        // Metodo per ricaricare la lista dei pazienti dopo il salvataggio
        private void AggiornaListaPazienti()
        {
            // Ricarica la lista dei pazienti dopo il salvataggio
            var pazienti = PazienteStore.GetAll();
            dataGridViewPazienti.DataSource = null;
            dataGridViewPazienti.DataSource = pazienti;
        }
    }
}

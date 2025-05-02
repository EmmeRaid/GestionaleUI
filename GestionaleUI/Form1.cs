using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionaleUI.FrontEnd;


namespace GestionaleUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AggiungiUtente_Click(object sender, EventArgs e)
        {
            // Pulisce il contenuto del panelContenuto
            panelContenuto.Controls.Clear();

            // Crea un'istanza del form "AggiungiUtenteForm" e lo aggiunge al pannello
            AggiungiUtente_Form aggiungiForm = new AggiungiUtente_Form();
            aggiungiForm.TopLevel = false;  // Permette di visualizzare il form come controllo
            aggiungiForm.Dock = DockStyle.Fill;  // Assicura che occupi tutto lo spazio del pannello
            panelContenuto.Controls.Add(aggiungiForm);
            aggiungiForm.Show();
        }

        private void ModificaUtente_Click(object sender, EventArgs e)
        {
            // Pulisce il contenuto del panelContenuto
            panelContenuto.Controls.Clear();

            // Crea un nuovo Label per "Modifica Utente"
            Label modificaLabel = new Label();
            modificaLabel.Text = "Modifica Utente";
            modificaLabel.AutoSize = true;
            modificaLabel.Location = new Point(10, 10); // Modifica la posizione a tuo piacimento

            // Aggiungi il Label al pannello contenuto
            panelContenuto.Controls.Add(modificaLabel);
        }

        private void EliminaUtente_Click(object sender, EventArgs e)
        {
            // Pulisce il contenuto del panelContenuto
            panelContenuto.Controls.Clear();

            // Crea un nuovo Label per "Elimina Utente"
            Label eliminaLabel = new Label();
            eliminaLabel.Text = "Elimina Utente";
            eliminaLabel.AutoSize = true;
            eliminaLabel.Location = new Point(10, 10); // Modifica la posizione a tuo piacimento

            // Aggiungi il Label al pannello contenuto
            panelContenuto.Controls.Add(eliminaLabel);
        }
        private void Esci_Click(object sender, EventArgs e)
        {
            // Chiude il form quando si preme il pulsante Esci
            this.Close();
        }
    }
}

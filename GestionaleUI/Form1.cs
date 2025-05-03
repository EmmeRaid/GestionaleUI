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

            // Crea una nuova istanza del controllo (NON riutilizzare una già aggiunta altrove)
            var aggiungiUtenteControl = new AggiungiPazienti();

            aggiungiUtenteControl.Dock = DockStyle.Fill;
            panelContenuto.Controls.Add(aggiungiUtenteControl);
        }

        private void ModificaUtente_Click(object sender, EventArgs e)
        {
            // Pulisce il contenuto del panelContenuto
            panelContenuto.Controls.Clear();

            // Crea una nuova istanza del controllo (NON riutilizzare una già aggiunta altrove)
            var modificaUtenteControl = new ModificaPaziente();

            modificaUtenteControl.Dock = DockStyle.Fill;
            panelContenuto.Controls.Add(modificaUtenteControl);
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

        private void VisualizzaUtente_Click(object sender, EventArgs e)
        {
            // Pulisce il contenuto del panelContenuto
            // Pulisce il contenuto del panelContenuto
            panelContenuto.Controls.Clear();

            // Crea una nuova istanza del controllo (NON riutilizzare una già aggiunta altrove)
            var VisualizzaUtente_Click = new StampaPazienti();

            VisualizzaUtente_Click.Dock = DockStyle.Fill;
            panelContenuto.Controls.Add(VisualizzaUtente_Click);
        }
        private void Esci_Click(object sender, EventArgs e)
        {
            // Chiude il form quando si preme il pulsante Esci
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionaleUI.BackEnd;

namespace GestionaleUI.FrontEnd
{
    public partial class StampaPazienti : UserControl
    {
        public StampaPazienti()
        {
            InitializeComponent();
            PazienteStore.CaricaDaFile(); // ✅ Carica i dati dal file JSON
            CaricaPazienti();
        }

        public class RigaPazienteEstesa
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string CodiceFiscale { get; set; }
            public DateTime DataNascita { get; set; }
            public string Farmaco { get; set; }
            public string Dosaggio { get; set; } // Aggiunto per il dosaggio
            public DateTime InizioPiano { get; set; }
            public DateTime FinePiano { get; set; }
        }

        private void CaricaPazienti()
        {
            var pazienti = PazienteStore.GetAll();
            var righe = new List<RigaPazienteEstesa>();

            foreach (var p in pazienti)
            {
                bool primaRiga = true;
                foreach (var piano in p.Piani)
                {
                    righe.Add(new RigaPazienteEstesa
                    {
                        Nome = primaRiga ? p.Nome : "",
                        Cognome = primaRiga ? p.Cognome : "",
                        CodiceFiscale = primaRiga ? p.CodiceFiscale : "",
                        DataNascita = primaRiga ? p.DataNascita : DateTime.MinValue,
                        Farmaco = piano.Farmaco,
                        InizioPiano = piano.Inizio,
                        FinePiano = piano.Fine,
                        Dosaggio = piano.Dosaggio, // Aggiunto per il dosaggio
                    });

                    primaRiga = false;
                }
            }

            dataGridView1.DataSource = righe; // ✅ Collega i dati alla DataGridView
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DataNascita" && e.Value is DateTime dt)
            {
                if (dt == DateTime.MinValue)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // facoltativo
        }
    }
}

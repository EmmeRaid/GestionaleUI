using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GestionaleUI.BackEnd
{
    internal static class PazienteStore
    {
        public static List<Paziente> ListaPazienti { get; } = new List<Paziente>();

        // Percorso assoluto del file pazienti.json
        private static readonly string filePath = @"C:\Users\bello\source\repos\EmmeRaid\GestionaleUI\GestionaleUI\Data\pazienti.json";

        public static void Aggiungi(Paziente p)
        {
            // Se esiste già un paziente con lo stesso CF, aggiungi il piano a lui
            var esistente = ListaPazienti.FirstOrDefault(x => x.CodiceFiscale == p.CodiceFiscale);
            if (esistente != null)
            {
                esistente.Piani.AddRange(p.Piani);
            }
            else
            {
                ListaPazienti.Add(p);
            }

            SalvaSuFile(); // salva subito dopo ogni aggiunta
        }

        public static List<Paziente> GetAll()
        {
            return new List<Paziente>(ListaPazienti);
        }

        public static void SalvaSuFile()
        {
            // Sincronizza il file con i dati correnti
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)); // Crea la cartella se non esiste

            // Scrivi nel file JSON
            string json = JsonConvert.SerializeObject(ListaPazienti, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void CaricaDaFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var lista = JsonConvert.DeserializeObject<List<Paziente>>(json);
                ListaPazienti.Clear();
                if (lista != null)
                    ListaPazienti.AddRange(lista);
            }
        }
    }
}

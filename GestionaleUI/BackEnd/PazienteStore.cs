using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GestionaleUI.BackEnd
{
    internal static class PazienteStore
    {
        public static List<Paziente> ListaPazienti { get; } = new List<Paziente>();

        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pazienti.json");

        public static void Aggiungi(Paziente p)
        {
            ListaPazienti.Add(p);
            SalvaSuFile(); // salva subito dopo ogni aggiunta
        }

        public static List<Paziente> GetAll()
        {
            return new List<Paziente>(ListaPazienti);
        }

        public static string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "pazienti.json");

        public static void SalvaSuFile()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath)); // Crea la cartella se non esiste
            string json = JsonConvert.SerializeObject(ListaPazienti, Formatting.Indented);
            File.WriteAllText(FilePath, json);
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

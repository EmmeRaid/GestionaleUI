using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleUI.BackEnd
{
    internal class Paziente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public DateTime DataNascita { get; set; }  // Può essere stringa, oppure DateTime se vuoi validazioni
        public string Farmaco { get; set; }
        public DateTime InizioPiano { get; set; } // Data di inizio del piano terapeutico
        public DateTime FinePiano { get; set; } // Data di fine del piano terapeutico   

        public Paziente(string nome, string cognome, string codiceFiscale, DateTime dataNascita, string farmaco, DateTime dataInizioPiano, DateTime dataFinePiano)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            DataNascita = dataNascita;
            Farmaco = farmaco;
            InizioPiano = dataInizioPiano; // Data di inizio del piano terapeutico 
            FinePiano = dataFinePiano; // Data di fine del piano terapeutico, ad esempio un mese dopo
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome} - CF: {CodiceFiscale} - Nascita: {DataNascita} - Farmaco: {Farmaco}";
        }
    }
}

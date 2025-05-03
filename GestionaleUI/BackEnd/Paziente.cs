using GestionaleUI.BackEnd;
using System.Collections.Generic;
using System;

public class Paziente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }
    public DateTime DataNascita { get; set; }
    public List<PianoTerapeutico> Piani { get; set; } = new List<PianoTerapeutico>();

    public Paziente(string nome, string cognome, string codiceFiscale, DateTime dataNascita)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        DataNascita = dataNascita;
    }

    public void AggiungiPiano(PianoTerapeutico piano)
    {
        Piani.Add(piano);
    }
}

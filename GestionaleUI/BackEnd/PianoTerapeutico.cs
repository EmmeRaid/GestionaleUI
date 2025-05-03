using System;

public class PianoTerapeutico
{
    public string Farmaco { get; set; }
    public string Dosaggio { get; set; } // Aggiunto per il dosaggio
    public DateTime Inizio { get; set; }
    public DateTime Fine { get; set; }

    public PianoTerapeutico(string farmaco, DateTime inizio, DateTime fine, string dosaggio)
    {
        Farmaco = farmaco;
        Inizio = inizio;
        Fine = fine;
        Dosaggio = dosaggio;
    }
}

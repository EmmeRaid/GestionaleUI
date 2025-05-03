using System;

public class PianoTerapeutico
{
    public string Farmaco { get; set; }
    public DateTime Inizio { get; set; }
    public DateTime Fine { get; set; }

    public PianoTerapeutico(string farmaco, DateTime inizio, DateTime fine)
    {
        Farmaco = farmaco;
        Inizio = inizio;
        Fine = fine;
    }
}

using System;

public class Tavara
{
    public string Nimi { get; set; }

    public Tavara(string nimi)
    {
        Nimi = nimi;
    }

    public override string ToString()
    {
        return Nimi;
    }
}

public class VariettyTavara<T>
{
    public T Tavara { get; }
    public ConsoleColor Vari { get; }

    public VariettyTavara(T tavara, ConsoleColor vari)
    {
        Tavara = tavara;
        Vari = vari;
    }

    public void NaytaTavara()
    {
        Console.ForegroundColor = Vari;
        Console.WriteLine(Tavara);
        Console.ResetColor();
    }
}

public class Miekka { }

public class Kirves { }

public class Jousi { }

class Program
{
    static void Main()
    {
        // Luodaan väritettyjä tavaroita
        var punainenMiekka = new VariettyTavara<Miekka>(new Miekka(), ConsoleColor.Red);
        var sininenKirves = new VariettyTavara<Kirves>(new Kirves(), ConsoleColor.Blue);
        var vihreäJousi = new VariettyTavara<Jousi>(new Jousi(), ConsoleColor.Green);

        // Tulostetaan väritetyt tavarat
        punainenMiekka.NaytaTavara();
        sininenKirves.NaytaTavara();
        vihreäJousi.NaytaTavara();

        Console.ReadLine();
    }
}
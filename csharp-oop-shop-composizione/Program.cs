using System;
using System.Collections.Generic;

class Prodotto
{
    public string Nome { get; set; }
    public double Prezzo { get; set; }
    public string Descrizione { get; set; }
    public string Categoria { get; set; }
}

class Negozio
{
    public string Nome { get; set; }
    public string Citta { get; set; }
    public string Indirizzo { get; set; }
    public int NumeroCivico { get; set; }
    public List<Prodotto> Prodotti { get; set; }

    public Negozio(string nome, string citta, string indirizzo, int numeroCivico)
    {
        Nome = nome;
        Citta = citta;
        Indirizzo = indirizzo;
        NumeroCivico = numeroCivico;
        Prodotti = new List<Prodotto>();
    }

    public override string ToString()
    {
        string risultato = $"Negozio: {Nome} - {Citta}, {Indirizzo} {NumeroCivico}\nProdotti:\n";
        foreach (Prodotto prodotto in Prodotti)
        {
            risultato += $"{prodotto.Nome} - {prodotto.Categoria} - {prodotto.Prezzo} euro\n";
        }
        return risultato;
    }

    public void AggiungiProdotto(Prodotto prodotto)
    {
        Prodotti.Add(prodotto);
    }

    public void AggiungiProdotti(List<Prodotto> prodotti)
    {
        Prodotti.AddRange(prodotti);
    }
}

// Esempio di utilizzo
Prodotto p1 = new Prodotto
{
    Nome = "Penne rigate",
    Prezzo = 1.5,
    Descrizione = "Pasta italiana di grano duro",
    Categoria = "Pasta"
};
Prodotto p2 = new Prodotto
{
    Nome = "Parmigiano reggiano",
    Prezzo = 10.0,
    Descrizione = "Formaggio italiano stagionato",
    Categoria = "Formaggi"
};

List<Prodotto> prodottiIniziali = new List<Prodotto> { p1, p2 };

Negozio negozio = new Negozio("Supermercato", "Milano", "Via Roma", 10);
negozio.AggiungiProdotti(prodottiIniziali);

Console.WriteLine(negozio);

Prodotto p3 = new Prodotto
{
    Nome = "Sugo alla amatriciana",
    Prezzo = 3.0,
    Descrizione = "Sugo italiano di pomodoro e pancetta",
    Categoria = "Sughi"
};
negozio.AggiungiProdotto(p3);

Console.WriteLine(negozio);
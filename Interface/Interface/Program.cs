// See https://aka.ms/new-console-template for more information


// Una interfaz es un contrato que define un conjunto de métodos, propiedades y eventos que una clase debe implementar.

var sale = new Sale();
var beer = new Beer();
//sale.Save();
//beer.Save();
Some(sale);
Some(beer);

void Some(ISave save)
{
    save.Save();
}


interface ISale
{
    public decimal Total { get; set; }
}

interface ISave
{
    public void Save();
}

public class Sale : ISale, ISave
{
    public decimal Total { get; set; }

    public void Save()
    {
        Console.WriteLine("Sale saved");
    }

}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Beer saved");
    }
}



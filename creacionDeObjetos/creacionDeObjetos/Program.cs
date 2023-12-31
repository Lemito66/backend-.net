// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sale = new SalesWithTax(300, 1.16m); // m es para indicar que es un decimal
var message = sale.GetInfo();
var messageWithTax = sale.GetInfo();

Console.WriteLine(message);
Console.WriteLine(messageWithTax);


// Herencia en C#
// Se la usa para reutilizar codigo, como por ejemplo en este caso, que se usa la clase Sale para crear la clase SalesWithTax
class SalesWithTax : Sale
{

    public decimal Tax { get; set; }
    public SalesWithTax(decimal total, decimal tax) : base(total) // base es para llamar al constructor de la clase padre
    {
        this.Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es: " + Total + " y el impuesto es: " + Tax;
    }

    // Sobrecarga de metodos
    public string GetInfo(string message)
    {
        return message;
    }
    public string GetInfo(string message, string message2)
    {
        return message + message2;
    }
}

class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        this.Total = total;
    }

    public virtual string GetInfo() // virtual es para que se pueda sobreescribir en la clase hija
    {
        return "El total es: " + Total;
    }
}
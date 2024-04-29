// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

// función lambda

var people = new People()
{
    Name = "Emill",
    Age = 26
};

string json = JsonSerializer.Serialize(people);
Console.WriteLine(json);

public class People()
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static string Get() => "Hello World!";
}




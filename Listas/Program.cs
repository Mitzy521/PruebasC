using System;
using System.Collections.Generic;

List<string> nombres = new List<string>();
nombres.Add("Jorge");
nombres.Add("Jose");
nombres.Add("Juan");

nombres.Insert(2, "Maria");

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

nombres.Remove("Jose");
Console.WriteLine("Lista después de eliminar Jose");
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
nombres.RemoveAt(0);
Console.WriteLine("Lista depués de eliminar el primer valor");
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
bool existe = nombres.Contains("luis");
Console.WriteLine($"¿Existe Luis en la lita? {existe}");

/*
class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        Console.WriteLine("Lista de numeros: ");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine($"El primer número de la lista es: {numeros[0]}");

        numeros.Remove(20);

        Console.WriteLine("Lista después de elimianr 20");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}
*/

/*
List<string> nombres = new List<string>();

nombres.Add("Ana");
nombres.Add("Luis");
nombres.Add("Carlos");

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
*/
/*
using System;
using System.Linq;
using System.Collections.Generic;

class Producto
{
    public string? Nombre;
    public double Precio;
}
class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Mouse", Precio = 85 },
            new Producto { Nombre = "Monitor", Precio = 950 },
            new Producto { Nombre = "Teclado", Precio = 120 }
        };
        var caros = productos.Where(p => p.Precio > 100).OrderBy(p => p.Precio);
        foreach (var p in caros)
        {
            Console.WriteLine($"{p.Nombre}, Q{p.Precio}");
        }

    }
}
*/
/*
class Program
{
    static void Main()
    {
        List<int> edades = new List<int> { 18, 22, 25, 17, 30 };

        var mayores = from e in edades
                      where e >= 18
                      select e;
        Console.WriteLine("Mayores de edad:");
        foreach (var edad in mayores)
        {
            Console.WriteLine(edad);
        }
    }
}
*/
using System;
using System.Collections.Generic;
/*
class Empleado
{
    public string? Nombre;
    public virtual double CalcularPago()
    {
        return 0;
    }
}

class Gerente
{
    public double SalarioBase;
    public double Bono;
    public override double CalcularPago()
    {
        return SalarioBase + Bono;
    }
}

class Operario : Empleado
{
    public int Horas;
    public double TarifaHora;
    public override double CalcularPago()
    {
        return Horas * TarifaHora;
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Gerente {Nombre = "Ana", SalarioBase = 3000, Bono = 500},
            new Operario {Nombre = "Luis", Horas = 40, TarifaHora = 25}
        };

        foreach (Empleado e in empleados)
        {
            Console.WriteLine($"{e.Nombre}, gana Q{e.CalcularPago()}");
        }
    }
}
*/

class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Los Animales Hacen un Sonido: ");
    }
}
class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Guau");
    }
}
class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>
        {
            new Animal(),
            new Perro(),
            new Gato()
        };
        foreach (Animal a in animales)
        {
            a.HacerSonido();
        }
    }
}
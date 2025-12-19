using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("División de dos números");

        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
    }
}

/*
class Program
{
    public static void Main()
    {
        Console.WriteLine("Validación de precio");

        Console.Write("Ingrese un precio (debe ser numérico y positivo): ");
        string entrada = Console.ReadLine();

        try
        {
            double precio = Convert.ToDouble(entrada);
            if (precio < 0)
            {
                throw new Exception("El precio no puede ser negativo.");
            }

            Console.WriteLine($"Precio válido ingresado: {precio}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: El valor ingresado no es un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
*/
/*
try
{
    int a = 1;
    int b = 0;
    int resultado = a / b;
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir en zero.");
}
finally
{
    Console.WriteLine("Operación Finalizada.");
}
*/
/*
try
{
    int dividendo = 10;
    int divisor = 0;
    int resultado = dividendo / divisor;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: no de puede dividir entre zero. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"ocurrio elgo inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Fin del bloque de manejo de excepciones.");
}
*/
/*
try
{
    Console.Write("Ingresa un entero: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Número Ingresado: {numero}");
}
catch(FormatException)
{
    Console.WriteLine($"Error: Debes ingresar un número váñido.");
}
*/

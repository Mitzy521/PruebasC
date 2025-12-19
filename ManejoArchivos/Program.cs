using System;
using System.IO;
using System.Net;
/*
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Admin\\OneDrive\\Documents\\Mitzy\\Progra\\Notas.txt";

        using (StreamWriter escritor = new StreamWriter(ruta))
        {
            escritor.WriteLine("Programación II - Manejo de Archivos");
            escritor.WriteLine("Autor: Mitzy Cu");
            escritor.WriteLine("Fecha: " + DateTime.Now);
        }

        Console.WriteLine("Archivo creado y escrito correctamente.");
    }
    
}
*/
/*
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Admin\\OneDrive\\Documents\\Mitzy\\Progra\\notas1.txt";

        if (File.Exists(ruta))
        {
            using (StreamReader lector = new StreamReader(ruta))
            {
                string? line;
                while ((line = lector.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
*/
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\Admin\\OneDrive\\Documents\\Mitzy\\Progra\\notas1.txt";

        using (StreamWriter escritor = new StreamWriter(ruta, append: true))
        {
            escritor.WriteLine("Nueva linea agregada " + DateTime.Now);
        }

        Console.WriteLine("Linea añadida al archivo");
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/*
namespace EjemploInterfaz
{
    interface IVehiculo
    {
        void Conducir();
        void Detener();
    }
    class Automovil : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("El automóvil se está conduciendo");
        }
        public void Detener()
        {
            Console.WriteLine("El automóvil se ha detenido");
        }
    }
    class Program
    {
        static void Main()
        {
            IVehiculo miVehiculo = new Automovil();
            miVehiculo.Conducir();
            miVehiculo.Detener();
        }
    }
}
*/
/*
namespace EjMensaje
{
    interface IMensaje
    {
        void Mensaje();
    }
    class Email : IMensaje
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola, Email");
        }
    }
    class Sms : IMensaje
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola, Mensaje de Texto");
        }
    }
    class What : IMensaje
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola, WhatsApp");
        }
    }
    class Program
    {
        static void Main()
        {
            List<IMensaje> mensajes = new List<IMensaje>
            {
                new Email(),
                new Sms(),
                new What()
            };
            foreach (IMensaje m in mensajes)
            {
                m.Mensaje();
            }
        }
    }
}
*/
/*
namespace EjemploIterfaz
{
    interface IMensaje
    {
        void Enviarmensaje(string mensaje);
    }

    class Email : IMensaje
    {
        public void Enviarmensaje(string mensaje)
        {
            Console.WriteLine("Enviando email con el mensaje: " + mensaje);
        }
    }
    class SMS : IMensaje
    {
        public void Enviarmensaje(string mensaje)
        {
            Console.WriteLine("Enviando SMS con el mensaje: " + mensaje);
        }
    }
    class WhatsApp : IMensaje
    {
        public void Enviarmensaje(string mensaje)
        {
            Console.WriteLine("Enviando WhatsApp con el mensaje: " + mensaje);
        }
    }
    class Program
    {
        static void Main()
        {
            IMensaje email = new Email();
            email.Enviarmensaje("Hola desde el email");
            IMensaje sms = new SMS();
            sms.Enviarmensaje("Hols desde el SMS");
            IMensaje whatsapp = new WhatsApp();
            whatsapp.Enviarmensaje("Hola desde el WhatsApp");
        }
    }
}
*/

interface IMensaje
{
    void Enviarmensaje(string mensaje);
}
interface Operacion
{
    void Encender();
    void Apagar();
}

class SmartTV : Operacion
{
    public void Encender()
    {
        Console.WriteLine("La Smart TV está encendida");
    }
    public void Apagar()
    {
        Console.WriteLine("La Smart TV está apagada");
    }
    public void EnviarMensaje(string mensaje)
    {
        Console.WriteLine("enviando mensaje desde la Smart TV: " + mensaje);
    }
}

class Program
{
    static void Main()
    {
        SmartTV miSmartTV = new SmartTV();
        miSmartTV.Encender();
        miSmartTV.EnviarMensaje("Hola desde la Smart TV");
        miSmartTV.Apagar();
    }
}
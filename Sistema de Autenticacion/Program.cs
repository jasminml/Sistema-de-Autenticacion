using System;
using System.Net.Security;

namespace Sistema_de_Autenticacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Autenticar auth = new Autenticar();
            bool seguir = true;
            //Se repetira mientras seguir sea true...
            while(seguir)
            {
                Console.WriteLine("\t SISTEMA DE IDENTIFICACIÓN");
                Console.WriteLine("\n");
                Console.WriteLine("Usuario (Cedula): ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Clave: ");
                string clave = Console.ReadLine();
                Console.Clear();
                string[] result = auth.ValidarUsuario(usuario, clave);
                Console.WriteLine("\n");
                Console.WriteLine("\t\t" + result[0]);
                Console.ReadKey();
                if (result[1].Equals("1"))
                {
                    seguir = false;
                }
                Console.Clear();
            }
        }
    }
}

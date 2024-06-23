using System;

namespace Aplicacion_DDD_ClienteDTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trabajo Practico de Laboratorio de Software");
            Console.WriteLine("Proyecto Hotel: Prueba Unitaria Capa Aplicacion ClienteDTO");
            Console.WriteLine();
            Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
            Console.WriteLine("Alumnos: Julia Avalos");
            Console.WriteLine("         Leonardo Caceres");
            Console.WriteLine("         Eduardo Arizza");
            Console.WriteLine("         Gonzalo Arizza");
            Console.WriteLine("         Omar Bazar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            // Ejemplo de uso de ClienteDTO:
            ClienteDTO cliente = new ClienteDTO
            {
                Id = 1,
                Nombre = "John",
                Apellido = "Doe",
                CorreoElectronico = "john.doe@example.com"
            };

            // Mostrar los datos del cliente por consola
            Console.WriteLine($"ID: {cliente.Id}");
            Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellido}");
            Console.WriteLine($"Correo Electrónico: {cliente.CorreoElectronico}");

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}

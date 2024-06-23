using System;

namespace Aplicacion_DDD_ClienteDTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? CorreoElectronico { get; set; }

        // Constructor sin parámetros requerido para las pruebas unitarias
        public ClienteDTO()
        {
        }

        // Constructor que inicializa las propiedades requeridas
        public ClienteDTO(int id, string nombre, string apellido, string correoElectronico)
        {
            Id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            CorreoElectronico = correoElectronico ?? throw new ArgumentNullException(nameof(correoElectronico));
        }
    }
}
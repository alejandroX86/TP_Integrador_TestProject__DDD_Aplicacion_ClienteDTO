using Xunit;

namespace TestProject_TP_DDD_ClienteDTO
{
    public class ClienteDTOTests
    {
        [Fact]
        public void ClienteDTO_CreaInstancia_SinErrores()
        {
            // Preparar
            var clienteDto = new Aplicacion_DDD_ClienteDTO.ClienteDTO
            {
                Id = 1,
                Nombre = "John",
                Apellido = "Doe",
                CorreoElectronico = "john.doe@example.com"
            };

            // Actuar y Afirmar
            Assert.Equal(1, clienteDto.Id);
            Assert.Equal("John", clienteDto.Nombre);
            Assert.Equal("Doe", clienteDto.Apellido);
            Assert.Equal("john.doe@example.com", clienteDto.CorreoElectronico);
        }

        [Fact]
        public void ClienteDTO_CorreoElectronico_NoEsNull()
        {
            // Preparar
            var clienteDto = new Aplicacion_DDD_ClienteDTO.ClienteDTO
            {
                Id = 2,
                Nombre = "Jane",
                Apellido = "Smith",
                CorreoElectronico = "jane.smith@example.com"
            };

            // Actuar y Afirmar
            Assert.NotNull(clienteDto.CorreoElectronico);
        }

        [Fact]
        public void ClienteDTO_CorreoElectronico_ContieneArrobaYDot()
        {
            // Preparar
            var clienteDto = new Aplicacion_DDD_ClienteDTO.ClienteDTO
            {
                Id = 3,
                Nombre = "Alice",
                Apellido = "Johnson",
                CorreoElectronico = "alice.johnson@example.com"
            };

            // Actuar y Afirmar
            Assert.Contains("@", clienteDto.CorreoElectronico);
            Assert.Contains(".", clienteDto.CorreoElectronico);
        }
    }
}
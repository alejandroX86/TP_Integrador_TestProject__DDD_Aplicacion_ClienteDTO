Proyecto Hotel Arquitectura DDD - Pruebas Unitarias

Este proyecto es un Trabajo Práctico de Laboratorio de Software que implementa una arquitectura DDD (Domain-Driven Design) para gestionar un sistema de reservas de hotel. En este documento se explica el funcionamiento de las pruebas unitarias, que son fundamentales para garantizar la fiabilidad y consistencia del sistema.

Pruebas Unitarias

Las pruebas unitarias son una parte esencial del desarrollo de software, ya que permiten verificar que los componentes individuales del sistema funcionen correctamente. En este proyecto, las pruebas unitarias se centran en la clase ClienteDTO, asegurando que sus propiedades y comportamientos sean los esperados.

Estructura de la Clase ClienteDTO

La clase ClienteDTO representa los datos del cliente y contiene las siguientes propiedades:

Id: Identificador único del cliente.
Nombre: Nombre del cliente.
Apellido: Apellido del cliente.
CorreoElectronico: Correo electrónico del cliente.
Pruebas Unitarias Implementadas
Se han implementado varias pruebas unitarias para asegurar la correcta funcionalidad de ClienteDTO:

Creación de Instancia sin Errores

Esta prueba verifica que una instancia de ClienteDTO se crea correctamente con los valores proporcionados para sus propiedades. Se asegura de que el objeto ClienteDTO se inicialice sin errores y que las propiedades Id, Nombre, Apellido y CorreoElectronico se asignen correctamente.
Correo Electrónico No Nulo

Esta prueba asegura que la propiedad CorreoElectronico de ClienteDTO no es nula después de la inicialización. Es crucial para evitar errores durante la manipulación de datos de cliente, donde se espera que el correo electrónico siempre tenga un valor.
Formato de Correo Electrónico

Esta prueba verifica que la propiedad CorreoElectronico contiene los caracteres '@' y '.' para asegurar que tiene un formato válido de dirección de correo electrónico. Esto ayuda a prevenir errores relacionados con el formato incorrecto del correo electrónico del cliente.
Cómo Ejecutar las Pruebas
Para ejecutar las pruebas unitarias, sigue estos pasos:

Clona el Repositorio

Clona el repositorio y abre el proyecto en tu IDE preferido.
Instala las Dependencias

Asegúrate de tener todas las dependencias necesarias instaladas en tu entorno de desarrollo.
Ejecuta las Pruebas

Navega a la carpeta de pruebas en tu proyecto y ejecuta los tests utilizando el comando de tu framework de pruebas. Por ejemplo, si estás usando XUnit, puedes usar el comando:
bash
Copiar código
dotnet test
Revisa los Resultados

Revisa los resultados de las pruebas para asegurarte de que todas pasen correctamente. Si alguna prueba falla, revisa el código para identificar y corregir el problema.
Importancia de las Pruebas Unitarias
Las pruebas unitarias son cruciales para el desarrollo de software de calidad debido a los siguientes motivos:

Detección Temprana de Errores

Ayudan a detectar errores en etapas tempranas del desarrollo, lo que facilita su corrección antes de que se conviertan en problemas mayores.
Evitación de Regresiones

Aseguran que los cambios en el código no introduzcan nuevos errores, permitiendo que el sistema evolucione sin comprometer la estabilidad.
Documentación del Comportamiento

Documentan el comportamiento esperado de los componentes del sistema, lo que es útil para los desarrolladores actuales y futuros.
Facilitación del Mantenimiento

Facilitan el mantenimiento y la evolución del sistema, ya que las pruebas aseguran que el código siga funcionando correctamente después de las modificaciones.
Contribución
Para contribuir al proyecto, sigue estos pasos:

Haz un Fork del Repositorio

Haz un fork del repositorio original a tu cuenta de GitHub.
Crea una Nueva Rama

Crea una nueva rama para tu funcionalidad o corrección (feature/nueva-funcionalidad).
Realiza tus Cambios

Realiza tus cambios y asegúrate de agregar nuevas pruebas unitarias si es necesario.
Envía un Pull Request

Envía un pull request al repositorio original para revisión.

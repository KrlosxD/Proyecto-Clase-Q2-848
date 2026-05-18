namespace ProyectoClase.DTOs;

public class RegisterDto
{
    //Lo que el frontend o el usuario desde una interfaz va a enviar
    //Cuando se quiera regisrar
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
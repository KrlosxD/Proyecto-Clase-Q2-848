namespace ProyectoClase.Models;

public class User
{
    //Representa un usuario dentro del sistema
    //Esta clase es lo que vamos a guardar en Firebase
    public string Id { get; set; } = string.Empty;
    
    public string FullName  { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    //La contraseña siempre va "encriptada" hasheada
    public string Password { get; set; } = string.Empty;
    
    //Por defecto cuando un usuario nuevo se cree, sera solo user
    public string Role { get; set; } = "user";
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
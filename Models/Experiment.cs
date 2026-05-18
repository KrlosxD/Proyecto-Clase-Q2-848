namespace ProyectoClase.Models;

//Representa un experimento o prueba que el usuario realizó
public class Experiment
{
    public string Id { get; set; } = string.Empty;
    
    //Titulo o nombre del experimento
    public string Title { get; set; } = string.Empty;
    
    //Resultado o resumen del experimento
    public string Result { get; set; } = string.Empty;
    
    //Guardamos el ID del usuario que creo el experimento o prueba
    public string UserId { get; set; } = string.Empty;
    
    //Resultado, funcionó o no
    public bool Success { get; set; } = false;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
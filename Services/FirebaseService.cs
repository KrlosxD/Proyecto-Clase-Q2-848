using Google.Cloud.Firestore;

namespace ProyectoClase.Services;

public class FirebaseService
{
    //Este archivo sirve de puente de comunicacion entre la app y firebase
    //TODAS LAS OPERACIONES PASAN POR AQUÍ SI O SI
    private readonly FirestoreDb _firestoreDb;

    public FirebaseService()
    {
        // Le vamos a decir a FB donde esta el archivo con las credenciales
        // Usamos la ruta del folder para encontrarla
        var credentialPath = Path.Combine(AppContext.BaseDirectory, "Config","firebase-config.json");
        
        //Una variable para que podamos utilizar el SDK de Google
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPath);
        
        //Ahora agregamos el id del proyecto para acceso a la Firebase Console
        _firestoreDb = FirestoreDb.Create("proyecto848-g3");
    }

    //Devuelve una referencia a una colección cualquiera que pidamos
    public CollectionReference GetCollection(string collectionName)
    {
        return _firestoreDb.Collection("collectionName");
    }
}
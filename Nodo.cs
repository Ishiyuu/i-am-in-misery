//Nodo para enlace
public class NodoActividad
{
    // insertar actividad.
    public string Actividad { get; set; } 
    // pasa al siguiente nodo.
    public NodoActividad Siguiente { get; set; }

    // Costruir el nodo.
    public NodoActividad(string actividad)
    {
        Actividad = actividad;
        Siguiente = null; 
    }
}
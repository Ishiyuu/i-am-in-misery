// Nodo para el Árbol Binario de Búsqueda.
public class NodoABB
{
    // El valor (tiempo en segundos).
    public int Valor { get; set; } 
    // Referencia al subárbol izquierdo.
    public NodoABB Izquierda { get; set; }
    // Referencia al subárbol derecho.
    public NodoABB Derecha { get; set; }

    // Constructor del nodo.
    public NodoABB(int valor)
    {
        Valor = valor;
        Izquierda = null;
        Derecha = null;
    }
}
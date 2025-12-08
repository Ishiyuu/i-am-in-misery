// Árbol Binario de Búsqueda para almacenar tiempos enteros.
public class ArbolBinarioBusqueda
{
    public NodoABB Raiz { get; private set; } // El nodo superior del árbol.
    private int _contador; // Contador de nodos.

    public ArbolBinarioBusqueda()
    {
        Raiz = null;
        _contador = 0;
    }

    /**
     * OPERACIONES REQUERIDAS
     */

    /// <summary>
    /// Inserción de un nuevo valor entero.
    /// </summary>
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
        _contador++;
        Console.WriteLine($" > Tiempo {valor} segundos insertado en el ABB.");
    }

    // Método privado recursivo para la inserción.
    private NodoABB InsertarRecursivo(NodoABB actual, int valor)
    {
        // Caso base: se encontró la posición de inserción.
        if (actual == null)
        {
            return new NodoABB(valor);
        }

        // Regla del ABB: si es menor, va a la izquierda; si es mayor, a la derecha.
        if (valor < actual.Valor)
        {
            actual.Izquierda = InsertarRecursivo(actual.Izquierda, valor);
        }
        else if (valor > actual.Valor)
        {
            actual.Derecha = InsertarRecursivo(actual.Derecha, valor);
        }
        // Si es igual, no se inserta (evitar duplicados, aunque el requerimiento no lo exige explícitamente).

        return actual;
    }

    /// <summary>
    /// Recorrido PreOrden: Raíz -> Izquierda -> Derecha.
    /// </summary>
    public void RecorrerPreOrden()
    {
        Console.Write("RECORRIDO PREORDEN (Raíz, Izq, Der): ");
        RecorrerPreOrdenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void RecorrerPreOrdenRecursivo(NodoABB nodo)
    {
        if (nodo != null)
        {
            // 1. Visitar la Raíz
            Console.Write($"{nodo.Valor} ");
            // 2. Recorrer Subárbol Izquierdo
            RecorrerPreOrdenRecursivo(nodo.Izquierda);
            // 3. Recorrer Subárbol Derecho
            RecorrerPreOrdenRecursivo(nodo.Derecha);
        }
    }

    /// <summary>
    /// Recorrido EnOrden: Izquierda -> Raíz -> Derecha (imprime los valores ordenados).
    /// </summary>
    public void RecorrerEnOrden()
    {
        Console.Write("RECORRIDO ENORDEN (Izq, Raíz, Der): ");
        RecorrerEnOrdenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void RecorrerEnOrdenRecursivo(NodoABB nodo)
    {
        if (nodo != null)
        {
            // 1. Recorrer Subárbol Izquierdo
            RecorrerEnOrdenRecursivo(nodo.Izquierda);
            // 2. Visitar la Raíz
            Console.Write($"{nodo.Valor} ");
            // 3. Recorrer Subárbol Derecho
            RecorrerEnOrdenRecursivo(nodo.Derecha);
        }
    }

    /// <summary>
    /// Recorrido PostOrden: Izquierda -> Derecha -> Raíz.
    /// </summary>
    public void RecorrerPostOrden()
    {
        Console.Write("RECORRIDO POSTORDEN (Izq, Der, Raíz): ");
        RecorrerPostOrdenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void RecorrerPostOrdenRecursivo(NodoABB nodo)
    {
        if (nodo != null)
        {
            // 1. Recorrer Subárbol Izquierdo
            RecorrerPostOrdenRecursivo(nodo.Izquierda);
            // 2. Recorrer Subárbol Derecho
            RecorrerPostOrdenRecursivo(nodo.Derecha);
            // 3. Visitar la Raíz
            Console.Write($"{nodo.Valor} ");
        }
    }

    /// <summary>
    /// Devuelve el número total de nodos en el ABB.
    /// </summary>
    public int ObtenerNumeroNodos()
    {
        // Se puede devolver el contador privado que se incrementa en la inserción.
        return _contador;
        // Alternativamente, se podría hacer un recorrido para contarlos, pero un contador es más eficiente.
    }
}
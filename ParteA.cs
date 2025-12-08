// Lista Enlazada Simple
public class ListaEnlazadaSimple
{
    public NodoActividad Cabeza { get; private set; } // el primer nodo
    public int Contador { get; private set; } // cautnos nodos hay

    public ListaEnlazadaSimple()
    {
        Cabeza = null;     //asegurarse de k esta pelado
        Contador = 0;
    }

    //meter una actividad al final
    public void InsertFinal(string actividad)
    {
        NodoActividad nuevoNodo = new NodoActividad(actividad);

        if (Cabeza == null)
        {
            // Si la lista está vacía el nuevo nodo es la cabeza
            Cabeza = nuevoNodo;
        }
        else
        {
            //revisa la lista
            NodoActividad actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            //agrega el nuevo nodo al final
            actual.Siguiente = nuevoNodo;
        }
        Contador++;
        Console.WriteLine($"  Actividad '{actividad}' insertada al final.");
    }

    //insertar en posicion especifica
    public void InsertPosicion(string actividad, int posicion)
    {
        if (posicion < 0 || posicion > Contador)
        {
            Console.WriteLine(" > ERROR: Posición fuera de rango.");
            return;
        }

        NodoActividad nuevoNodo = new NodoActividad(actividad);

        if (posicion == 0)
        {
            // insertar al inicio
            nuevoNodo.Siguiente = Cabeza;
            Cabeza = nuevoNodo;
        }
        else
        {
            // buscar el nodo anterior a la posición
            NodoActividad actual = Cabeza;
            for (int i = 0; i < posicion - 1; i++)
            {
                actual = actual.Siguiente;
            }
            // enlazar el nuevo nodo
            nuevoNodo.Siguiente = actual.Siguiente;
            // enlazar el nodo anterior
            actual.Siguiente = nuevoNodo;
        }
        Contador++;
        Console.WriteLine($" > Actividad '{actividad}' insertada en la posición {posicion}.");
    }

    //eliminar un nodo de una posicion especifica
    public void EliminarPorPosicion(int posicion)
    {
        if (Cabeza == null)
        {
            Console.WriteLine(" > ERROR: La lista está vacía.");
            return;
        }

        if (posicion < 0 || posicion >= Contador)
        {
            Console.WriteLine(" > ERROR: Posición fuera de rango.");
            return;
        }

        string actividadEliminada;
        if (posicion == 0)
        {
            // eliminar la cabeza
            actividadEliminada = Cabeza.Actividad;
            Cabeza = Cabeza.Siguiente;
        }
        else
        {
            // buscar el nodo anterior al que se desea eliminar
            NodoActividad actual = Cabeza;
            for (int i = 0; i < posicion - 1; i++)
            {
                actual = actual.Siguiente;
            }
            // guardar el valor antes de saltar el nodo
            actividadEliminada = actual.Siguiente.Actividad;
            // saltar el nodo a eliminar.
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
        Contador--;
        Console.WriteLine($" > Nodo eliminado en la posición {posicion}: '{actividadEliminada}'.");
    }

    //imprime toda la lista
    public void ImprimirLista()
    {
        if (Cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoActividad actual = Cabeza;
        Console.Write("LISTA DE ACTIVIDADES: ");
        while (actual != null)
        {
            // imprime el valor del nodo
            Console.Write($"[{actual.Actividad}]");
            // agrega una flecha si no es el último nodo
            if (actual.Siguiente != null)
            {
                Console.Write(" -> ");
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}
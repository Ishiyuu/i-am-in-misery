using System;



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║        MODELO DE BITÁCORA SIMPLE       ║");
        Console.WriteLine("╚════════════════════════════════════════╝");

        // 1. Inicializar las estructuras
        ListaEnlazadaSimple bitacoraActividades = new ListaEnlazadaSimple();
        ArbolBinarioBusqueda tiemposABB = new ArbolBinarioBusqueda();

        // 2. Solicitar actividades y tiempos (Mínimo 5)
        Console.WriteLine("\n--- SOLICITUD DE ACTIVIDADES (Lista Enlazada) ---");
        List<string> actividades = new List<string>
        {
            "Login en la plataforma",
            "Consulta de saldo",
            "Generación de reporte",
            "Cambio de clave",
            "Descarga de archivo",
            "Cierre de sesión" // Una extra de regalo
        };

        foreach (var act in actividades)
        {
            // Almacenar en la Lista: se usa InsertarAlFinal para mantener el orden de ocurrencia.
            bitacoraActividades.InsertarAlFinal(act);
        }
        
        // Ejemplo de otra operación de la lista: Insertar en una posición específica
        Console.WriteLine("\n--- DEMOSTRACIÓN DE OPERACIONES ADICIONALES DE LISTA ---");
        bitacoraActividades.InsertarEnPosicion("Visualización de video", 3);
        bitacoraActividades.EliminarPorPosicion(1); // Elimina la actividad en la posición 1 (base 0)

        Console.WriteLine("\n--- SOLICITUD DE TIEMPOS (ABB) ---");
        List<int> tiempos = new List<int> { 15, 8, 22, 10, 3, 25 };
        
        foreach (var tiempo in tiempos)
        {
            // Almacenar en el ABB: se usa Insertar para mantener la propiedad de ordenamiento.
            tiemposABB.Insertar(tiempo);
        }


        // 3. Impresión de Resultados Requeridos
        Console.WriteLine("\n\n╔════════════════════════════════════════╗");
        Console.WriteLine("║        RESULTADOS FINALES              ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        
        // A. Imprimir la lista completa
        Console.WriteLine("\n--- IMPRESIÓN DE LISTA ENLAZADA COMPLETA ---");
        bitacoraActividades.ImprimirLista();
        
        // B. Imprimir el recorrido EnOrden del ABB
        Console.WriteLine("\n--- RECORRIDO ENORDEN DEL ABB (Tiempos Ordenados) ---");
        tiemposABB.RecorrerEnOrden();

        // C. Imprimir la cantidad de nodos del ABB
        Console.WriteLine("\n--- CANTIDAD DE NODOS DEL ABB ---");
        Console.WriteLine($"El ABB contiene un total de {tiemposABB.ObtenerNumeroNodos()} nodos (tiempos).");

        // Impresiones adicionales para completar:
        Console.WriteLine("\n--- RECORRIDOS ADICIONALES DEL ABB ---");
        tiemposABB.RecorrerPreOrden();
        tiemposABB.RecorrerPostOrden();

        Console.WriteLine("\nFIN DEL PROGRAMA.");
    }
}
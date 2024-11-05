namespace _03_ListaLigada;

public class CListaLigada
{
    private CNodo ancla; // Ancla o cbaeza de la lista
    private CNodo trabajo; // Variable de referencia para trabajar con la lista
    private CNodo trabajo2; // Otra variale de referencia que nos ayudará a trabajar con ciertas operaciones de la lista
    
    // Constructor de la lista ligada
    public CListaLigada()
    {
        ancla = new CNodo(); // Instanciamos el ancla o cabeza
        ancla.Siguiente = null; // Como es una lista vacía el siguiente es null
        
    }

    public void Transversa()
    {
        trabajo = ancla; // Ponemos trabajo al inicio

        if (trabajo.Siguiente == null)
        {
            Console.WriteLine("Lista vacía");
        }
        while (trabajo.Siguiente != null)
        {
            trabajo = trabajo.Siguiente; // Avanzamos trabajo al siguiente nodo

            int d = trabajo.Dato; // Obteniendo el dato o contenido del nodo y lo guardamos en la variable d
            Console.Write("[{0}] => ", d); // Imprimiendo el dato
        }
        
        //Print solo imprimir una línea
        Console.WriteLine();
    }

    public void Adicionar(int pDato)
    {
        trabajo = ancla; // Iniciamos trabajo al inicio
        while (trabajo.Siguiente != null)
        {
            trabajo = trabajo.Siguiente; // Avanzamos trabajo
        }

        CNodo temp = new CNodo(); // Creamos el nuevo nodo
        temp.Dato = pDato; // Insertamos el dato
        temp.Siguiente = null; // Finalizamos en null 
        trabajo.Siguiente = temp; // ligamos el último nodo encontrado
    }
}
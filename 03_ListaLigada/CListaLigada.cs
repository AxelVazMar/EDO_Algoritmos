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

    // Método para vaciar la lista
    public void Vaciar()
    {
        ancla.Siguiente = null;
        // En otro tipo de lenguajes tenemos que liberar la memoria
    }

    public bool EstaVacia()
    {
        if (ancla.Siguiente == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Regresa el primer dato encontrado si tenemos 2, 5, 6, 7, 5 y buscamos el 5 nos regresaría el primer 5
    public CNodo Buscar(int pDato)
    {
        // Revisamos si está vacía
        if (EstaVacia() == true)
            return null;

        trabajo2 = ancla;

        // Recorreremos la lista para ver si encontramos un nodo
        while (trabajo2.Siguiente != null)
        {
            trabajo2 = trabajo2.Siguiente;

            // Al encontrar el dato lo regresamos
            if (trabajo2.Dato == pDato)
                return trabajo2;
        }

        return null; // No se encontró el nodo regresamos null
    }

    // Buscamo el indice donde se encunetra la primera ocurrencia del dato, si tenemos 5, 6, 4, 5 = regresaría 0, ya que es el primer elemento de la lista
    public int BuscarIndice(int pDato)
    {
        int n = -1;

        trabajo = ancla;

        while (trabajo.Siguiente != null)
        {
            trabajo = trabajo.Siguiente;
            n++;

            if (trabajo.Dato == pDato)
                return n; // Regresamos el indice del nodo
        }

        return -1;
    }

    // Encuentra el nodo anterior
    // Si está en el primer nodo se regresa el ancla
    // Si el dato no existe se regresa el último nodo

public CNodo BuscarAnterior(int pDato)
    {
        trabajo2 = ancla;
            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
                trabajo2 = trabajo2.Siguiente;
            return trabajo2;
    }
}
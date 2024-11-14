namespace _05_InsertionSort;

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

    // Buscamo el indice donde se encunetra la primera ocurrencia del dato, si tenemos 5, 6, 4, 5 y buscamos 5 regresaría 0, ya que es el primer elemento de la lista
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

    public void Borrar(int pDato)
    {
        // Si está vacía no hacemos lo demás y regresamos que está vacía
        if (EstaVacia() == true)
            return;
        CNodo anterior = BuscarAnterior(pDato);
        CNodo encontrado = Buscar(pDato);

        // Si no hay nodo que borrar salimos
        if (encontrado == null)
        {
            Console.WriteLine("No existe el dato");
            return;
        }

        //Brincamos el nodo
        anterior.Siguiente = encontrado.Siguiente;
        
        // Quitamos el nodo de la lista
        encontrado.Siguiente = null;
    }

    // Inserta el dato "pValor" después de del dato "pDonde". Ejemplo: lista = 1, 5, 4, 5 y quiero insertar un 8 después del 5 quedaría así la lista
    // lista = 1, 5, 8, 4, 5
    public void Insertar(int pDonde, int pValor)
    {
        // Encontramos la posición donde vamos a insertar
        trabajo = Buscar(pDonde);
        // verificamos que exista el dato donde vamos a insertar
        if (trabajo == null)
        {
            Console.WriteLine("No existe el dato");
            return;
        }

        // Creamos el nodo temporal donde vamos a insertar
        CNodo temp = new CNodo();
        temp.Dato = pValor;
        
        // Conectamos el nodo temporal a insertar
         temp.Siguiente = trabajo.Siguiente;
         
         // Conectamos [trabajo] => [temporal]
         trabajo.Siguiente = temp;
    }

    public void InsertarInicio(int pValor)
    {
        // Creamos el nodo temporal
        CNodo temp = new CNodo();
        temp.Dato = pValor;
        
        // Conectamos el nodo temporal antes del ancla ejemplo lista= [3] => [5] => [7] => [9] => [11] => [15] insertaremos el 7 al inicio
        // [ancla] => [7] => [3] => [5] => [7] => [9] => [11] => [15]
        temp.Siguiente = ancla.Siguiente;
        
        // Conectamos temporal con la lista con la lista 
        ancla.Siguiente = temp;
    }

    public CNodo BuscarPorIndice(int pIndice)
    {
        CNodo trabajo2 = null;
        int indice = -1;

        trabajo = ancla;

        if (trabajo.Siguiente == null)
        {
            return null;
        }

        while (trabajo.Siguiente != null)
        {
            trabajo = trabajo.Siguiente;
            indice++;

            if (indice == pIndice) 
                trabajo2 = trabajo;
        }
        return trabajo2;
    }

    public int this[int pIndice]
    {
        get
        {
            trabajo = BuscarPorIndice(pIndice);
            return trabajo.Dato;
        }

        set
        {
            trabajo = BuscarPorIndice(pIndice);
            if (trabajo != null)
            {
                trabajo.Dato = value;
            }
        }
    }

    public int Cantidad()
    {
        trabajo = ancla;
        int n = 0;
        while (trabajo.Siguiente != null)
        {
            trabajo = trabajo.Siguiente;
            n++;
        }
        return n;
    }
}
namespace _03_ListaLigada
{
    class program
    {
        static void Main(string[] args)
        {
            // Creando la lista ligada
            CListaLigada miLista = new CListaLigada();
            // adicionando elementos en la lista
            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);
            
            miLista.Transversa(); // recorriendo la lista
            /*Console.WriteLine(miLista.EstaVacia());
            
            miLista.Vaciar();
            
            miLista.Transversa();
            Console.WriteLine(miLista.EstaVacia());*/

            CNodo encontrado = miLista.Buscar(9);
            Console.WriteLine("Nodo encontrado: {0}", encontrado);
        }
    }
}
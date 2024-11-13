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

            /*CNodo encontrado = miLista.Buscar(9);
            
            Console.WriteLine("Nodo encontrado: {0}", encontrado);
            
            // Buscando el indice del número 7
            Console.WriteLine("Indice encontrado: {0}", miLista.BuscarIndice(15));

            Console.WriteLine("Nodo anterior encontrado: {0}", miLista.BuscarAnterior(15));*/
            
            //miLista.Borrar(7);
            // Aquí estamos insertando el 20, después del 7 por lo que lista quedará así 3, 5, 7, 20, 9, 11, 15
            miLista.Insertar(152, 20);
            miLista.Transversa();
            miLista.InsertarInicio(4);
            miLista.Transversa();
            //Console.WriteLine(miLista.BuscarPorIndice(3));

            Console.WriteLine(miLista[3]);
            miLista[3] = 55;
            miLista.Transversa();
        }
    }
}
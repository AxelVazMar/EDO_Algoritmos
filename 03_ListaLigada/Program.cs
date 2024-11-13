namespace _03_ListaLigada
{
    class program
    {
        public static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args)
        {
            
            // adicionando elementos en la lista
            miLista.Adicionar(22);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);
            
            //miLista.Transversa(); // recorriendo la lista
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
            //miLista.Insertar(152, 20);
            //miLista.Transversa();
            //miLista.InsertarInicio(4);
            //miLista.Transversa();
            //Console.WriteLine(miLista.BuscarPorIndice(3));

            //Console.WriteLine(miLista[3]);
            //miLista[3] = 55;
            miLista.Transversa();
            BubbleSort();
        }

        private static void Swap(int i1, int i2)
        {
            int aux = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = aux;
        }

        private static void BubbleSort()
        {
            int cantidad = miLista.Cantidad();
            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad-1; j++)
                {
                    if (miLista[j] > miLista[j + 1])
                    {
                        Swap(j, j+1);
                    }
                }

                Console.WriteLine("Pase número {0}", i);
                miLista.Transversa();
            }

            Console.WriteLine("Lista ordenada: ");
            miLista.Transversa();
        }
    }
}
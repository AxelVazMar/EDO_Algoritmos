namespace _05_InsertionSort
{
    class Program
    {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args)
        {
            // adicionando elementos en la lista
            miLista.Adicionar(22);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);
            
            miLista.Transversa();

            int cantidad = miLista.Cantidad();
            int i = 0;
            int posAgujero = 0;
            int dato = 0;
            for (i = 1; i < cantidad; i++)
            {
                dato = miLista[i];
                posAgujero = i;
                while (posAgujero > 0 && miLista[posAgujero - 1] > dato)
                {
                    miLista[posAgujero] = miLista[posAgujero - 1];
                    posAgujero--;
                    miLista.Transversa();
                }
                miLista[posAgujero] = dato;
            }
        }
    }
}
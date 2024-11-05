namespace _03_ListaLigada;

public class CNodo
{
    private int dato; // Aquí colocaremos el datos que guardará el nodo
    private CNodo siguiente = null; // Esta es una variable de referencia para apuntar al nodo siguiente
    
    // Propiedades
    public int Dato { get => dato; set => dato = value; }
    internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

    // Método para imprimir
    public override string ToString()
    {
        return string.Format("[{0}]", dato);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // 1, 1, 2, 3, 5, 8, 13
        // 0, 1, 2, 3, 4, 5, 6 = Indinces

        int f = 0;
        f = Fib(4);
        Console.WriteLine(f);
    }

    static public int Fib(int n)
    {
        int r = 0;
        
        // Caso indctivo
        if (n > 1)
        {
            r = Fib(n - 1) + Fib(n - 2);
        }
        
        // Caso base
        if (n <= 1)
        {
            r = 1;
        }

        return r;
    }
}
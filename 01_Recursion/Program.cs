class Program
{
    static void Main(string[] args)
    {
        int f = 0;
        //Factorial de 5! = 5*4*3*2*1
        f = Factorial(1);
        Console.WriteLine(f);

    }

    public static int Factorial(int n)
    {
        int r = 0;
        // Caso inductivo
		if (n > 1)
        {
            r = n * Factorial(n - 1);
        }

        if (n == 1)
        {
            r = 1;
        }

        return r;
    }
}


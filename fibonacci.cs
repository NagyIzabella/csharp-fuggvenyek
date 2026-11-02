// Fibonacci

int fibo(int n)
{
    List<int> lista = new() {0, 1};
    int mostani = 0;

    for (int i = 2; i < n + 1; i++)
    {
        mostani = lista[i-1] + lista[i-2];
        lista.Add(mostani);
    }

    return mostani;
}

Console.WriteLine(fibo(42));
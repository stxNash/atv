{
    int a = 2;
    int[] v = new int[10];
    while (a < 6)
    {
        v[a] = 10 * a;
        a += 1;
    }
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine(v[i]);
    }
}

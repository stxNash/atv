{
    int a = 7;
    int b = a - 6;
    int [] v =  new int [10];
    while (b < a)
    {
        v [b] = b + a;
        b = b + 2;
    }
    for (int i = 0; i < 6; i++)
    {
        if (v[i] != 0) 
        {
            Console.WriteLine(v[i]);
        }
    }
}

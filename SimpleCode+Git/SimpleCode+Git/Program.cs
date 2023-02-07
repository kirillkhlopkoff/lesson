class Program
{
    static void Foo(int i, int length)
    {
        Console.WriteLine(i);
        if(i<= length)
        {
            i++;
            Foo(i, length);
        }
        
        
    }
    static void Main(string[] args)
    {
        int[] arr = new int[4] { 1, 5, 9, 0 };
        int i = 0;
            Foo(arr[i], arr.Length);
    }
}


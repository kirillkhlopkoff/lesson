class Program
{
    static int Sum(int[] myArray, int i = 0)
    {
        if(i>= myArray.Length)
        {
            return 0;
        }
        int result = Sum(myArray, i + 1);
        return myArray[i] + result;
    }
    static void Main(string[] args)
    {
        int[] myArray = { 2, 6, 12, 22, 14 };
        int result = Sum(myArray);
        Console.WriteLine(result);
    }
}


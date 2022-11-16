class pz_13
{
    public static int CountOfPowersOfTwo(int[] numbers)
    {
        int counter = 0;
        
        foreach (int number in numbers)
        {
            if (number != 1 && Math.Log(number, 2) * 10 % 10 == 0)
            {
                counter++;
            }
        }

        return counter;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(CountOfPowersOfTwo(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}));
    }
}

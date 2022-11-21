class pz_14
{
    public static double ArithmeticProgression(int numberOfElement, int numberOfNecessaryElement, double result)
    {
        double step = -2;

        if (numberOfElement == numberOfNecessaryElement)
        {
            return result;
        }
        
        return ArithmeticProgression(numberOfElement + 1, numberOfNecessaryElement, result + step);
        
    }

    public static double GeometricProgression(int numberOfElement, int numberOfNecessaryElement, double result)
    {
        double step = -2;

        if (numberOfElement == numberOfNecessaryElement)
        {
            return result;
        }
        
        return GeometricProgression(numberOfElement + 1, numberOfNecessaryElement, result * step);
    }

    public static void FromAToB(int A, int B)
    {
        Console.Write($"{A}  ");

        if (A < B)
        {
            FromAToB(A + 1, B);
        }
        else if (A > B)
        {
            FromAToB(A - 1, B);
        }
    }

    public static int MaxElement(int first, int second)
    {
        return first > second ? first : second;
    }
    
    public static int MaxInt(int[] array, int sizeOfArray)
    {
        if (sizeOfArray == 1)
        {
            return array[0];
        }
        else if (sizeOfArray == 2)
        {
            return MaxElement(array[0], array[1]);
        }
        else
        {
            return MaxElement(array[sizeOfArray - 1], MaxInt(array, sizeOfArray - 1));
        }
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("=== 1 task ===");
        
        Console.Write("Enter the number of necessary element: ");
        int numberOfNecessaryElementOfArithmeticProgression = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(ArithmeticProgression(1, numberOfNecessaryElementOfArithmeticProgression, -10));
        
        
        Console.WriteLine("=== 2 task ===");
        
        Console.Write("\nEnter the number of necessary element: ");
        int numberOfNecessaryElementOfGeometricProgression = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(GeometricProgression(1, numberOfNecessaryElementOfGeometricProgression, 12));
        
        
        Console.WriteLine("=== 3 task ===");

        FromAToB(54, 6);
        
        
        Console.WriteLine("=== 4 task (5) ===");

        int[] arrayA = { 3, 5, 6, 8, 7, 0, 4, 2, 1, 9 };
        int[] arrayB = { 1, 6, 5, 9, 2, 8, 7, 0, 4, 3 };
        int[] arrayC = { 9, 1, 6, 8, 2, 5, 3, 7, 0, 4 };
        
        Console.WriteLine(MaxInt(arrayA, arrayA.Length));
        Console.WriteLine(MaxInt(arrayB, arrayB.Length));
        Console.WriteLine(MaxInt(arrayC, arrayC.Length));
    }
}
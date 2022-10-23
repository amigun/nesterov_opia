int row = 10, col = 10;

int[,] matrix = new int[row, col];
Random random = new Random();
int count = 0;

Console.WriteLine("! The elements of the main diagonal are in []\n");

for (int i = 0; i < row; ++i)
{
    for (int j = 0; j < col; ++j)
    {
        int element = random.Next(-100, 100);
        matrix[i, j] = element;

        if (i != j)
        {
            Console.Write(element + "\t");
        }
        else
        {
            Console.Write("[" + element + "]\t");
        }

        if (i > j && element < 0)
        {
            count++;
        }
    }
    
    Console.WriteLine();
}

Console.WriteLine($"The number of negative elements under the main diagonal: {count}");
int[] array = {5, 3, -1, 8, 0, -6, 1};

bool negative = false;
int sum = 0;

foreach (int number in array)
{
    if (!negative)
    {
        if (number < 0)
        {
            negative = true;
        }
    }
    else
    {
        sum += Math.Abs(number);
    }
}

Console.WriteLine(sum);
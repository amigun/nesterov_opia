Console.Write("Enter the number of the task (1-5): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        for (int i = 10; i < 70; i += 5)
        {
            Console.WriteLine(i);
        }
        break;
    case 2:
        // У меня бесконечно выводит различные символы из UTF-8, работает не совсем корректно
        // Пробовали точно такой же вариант на Visual Studio в кабинете, все работало как часы
        for (char ch = 'Г'; ch <= ch + 8; ch++)
        {
            Console.Write(ch);
        }
        break;
    case 3:
        for (int m = 0; m < 9; ++m)
        {
            for (int n = 0; n < 4; ++n)
            {
                Console.Write('#');
            }
            Console.Write('\n');
        }
        break;
    case 4:
        for (int i = 0; i <= 100; ++i)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
        break;
    case 5:
        for (int i = 5, j = 64; j - i >= 23; ++i, --j)
        {
            Console.WriteLine($"i = {i},\tj = {j}");
        }
        break;
    default:
        Console.WriteLine("Incorrect value! Try again");
        break;
}
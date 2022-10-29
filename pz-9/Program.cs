// 1 task
Random random = new Random();

string[][] strings = new string[6][];

for (int i = 0; i < strings.Length; ++i)
{
    int lengthNewArray = random.Next(2, 10);
    strings[i] = new string[lengthNewArray];

    for (int j = 0; j < lengthNewArray; ++j)
    {
        // Generating a random string
        string[] dict = new string[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
            "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
        };
        
        string randomString = "";
        int lengthNewWord = random.Next(5, 8);

        for (int k = 0; k < lengthNewWord; ++k)
        {
            randomString += dict[random.Next(0, dict.Length)];
        }

        // Adding a new word
        strings[i][j] = randomString;
    }
}


// 2 task
Console.WriteLine("@ 2 task");
foreach (string[] str in strings)
{
    foreach (string randomStr in str)
    {
        Console.Write(randomStr + '\t');
    }
    Console.WriteLine();
}


//3 task
string[] arrayOfLastElements = new string[strings.Length];

for (int i = 0; i < strings.Length; ++i)
{
    arrayOfLastElements[i] = strings[i][strings[i].Length - 1];
}

Console.WriteLine("\n@ 3 task");
foreach (string element in arrayOfLastElements)
{
    Console.Write(element + ' ');
}

// 6 task
for (int i = 0; i < strings.Length; ++i)
{
    string[] strs = (string[])strings[i].Clone();

    for (int j = strs.Length; j > 0; --j)
    {
        strings[i][strs.Length - j] = strs[j-1];
    }
}

Console.WriteLine("\n\n@6 task");
foreach (string[] str in strings)
{
    foreach (string randomStr in str)
    {
        Console.Write(randomStr + '\t');
    }
    Console.WriteLine();
}


// 7 task
Console.WriteLine("\n@ 7 task");
foreach (string[] str in strings)
{
    int sum = 0;

    foreach (string randomStr in str)
    {
        sum += randomStr.Length;
    }
    
    Console.WriteLine(sum);
}
Console.WriteLine("Enter the text: ");
string[] input = Console.ReadLine().Split();

foreach (string word in input)
{
    bool isNumber = true;
    
    foreach (var letter in word)
    {
        if (!char.IsNumber(letter))
        {
            isNumber = false;
            break;
        } 
    }

    if (isNumber)
    {
        Console.WriteLine(word);
    }
}
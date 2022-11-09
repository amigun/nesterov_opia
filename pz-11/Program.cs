string[] sentences = Console.ReadLine().Split(". ");

foreach (string word in sentences[0].Split())
{
    if (sentences[1].Split().Contains(word))
    {
        Console.WriteLine(word);
    }
}
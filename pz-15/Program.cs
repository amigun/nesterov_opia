// 17

using (FileStream fstream = File.OpenRead("../../../file.txt"))
{
    StreamReader sreader = new StreamReader(fstream);

    int count_lines = 0, count_words = 0;
    
    foreach(string line in sreader.ReadToEnd().Split('\n'))
    {
        Console.WriteLine(line);
        count_lines++;
        count_words += line.Split().Length;
    }
    
    Console.WriteLine($"Count of lines: {count_lines}\nCount of words: {count_words}");
}

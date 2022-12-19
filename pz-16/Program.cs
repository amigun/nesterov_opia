// 17

using (FileStream fstream = File.OpenRead("../../../file.txt"))
{
    StreamReader sreader = new StreamReader(fstream);

    double average_mark = 0;
    int count_lines = 0;
    
    foreach(string line in sreader.ReadToEnd().Split('\n'))
    {
        string[] pieces = line.Split();

        string name = pieces[0], surname = pieces[1];
        int mark = Convert.ToInt32(pieces[2]);

        if (mark < 3)
        {
            Console.WriteLine($"Student: {name} {surname} has a mark below 3");
        }

        average_mark += mark;
        count_lines++;
    }

    average_mark /= count_lines;
    
    Console.WriteLine($"\nAverage mark by class: {Math.Round(average_mark, 2)}");
}

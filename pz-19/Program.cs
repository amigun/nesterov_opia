using System.Text.RegularExpressions;

Console.Write("Enter the task (1, 2): ");
string task = Console.ReadLine();

switch (task)
{
    case "1":
        using (FileStream fstream = File.OpenRead("../../../text.txt"))
        {
            StreamReader sreader = new StreamReader(fstream);
            
            string text_1 = sreader.ReadToEnd();

            string pattern_1 = @"\d{1} ([А-Яа-я]+ [А-Яа-я]{0,} [А-Яа-я]{0,}) ?\+";
            
            foreach (Match match in new Regex(pattern_1).Matches(text_1))
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
        break;
    case "2":
        using (FileStream fstream = File.OpenRead("../../../connects.log"))
        {
            StreamReader sreader = new StreamReader(fstream);
            
            string text_2 = sreader.ReadToEnd();

            string pattern2 = @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})[\s-]*\[(\d{1,2}\/\w{3}\/\d{4})";
            
            foreach (Match match in new Regex(pattern2).Matches(text_2))
            {
                Console.WriteLine($"{match.Groups[1].Value}\t{match.Groups[2].Value}");
            }
        }
        break;
}
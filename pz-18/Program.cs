FirstTask();
Console.WriteLine();
SecondTask();

void FirstTask()
{
    Console.Write("Enter the mark: ");
    int mark = Convert.ToInt32(Console.ReadLine());

    switch (mark)
    {
        case (int)Marks.VERY_BAD:
            Console.WriteLine($"{(int)Marks.VERY_BAD} is very bad mark");
            break;
        case (int)Marks.NOTSATISFACTORY:
            Console.WriteLine($"{(int)Marks.NOTSATISFACTORY} is not satisfactory mark");
            break;
        case (int)Marks.SATISFACTORY:
            Console.WriteLine($"{(int)Marks.SATISFACTORY} is satisfactory mark");
            break;
        case (int)Marks.GOOD:
            Console.WriteLine($"{(int)Marks.GOOD} is good mark");
            break;
        case (int)Marks.VERY_GOOD:
            Console.WriteLine($"{(int)Marks.VERY_GOOD} is very good mark");
            break;
    }
}

void SecondTask()
{
    string[] seasons =
    {
        "summer", "autumn", "winter", "spring"
    };

    string[] summer_holydays = { "1. Summer holyday", "2. Summer holyday", "3. Summer holyday" };
    string[] autumn_holydays = { "1. Autumn holyday", "2. Autumn holyday", "3. Autumn holyday" };
    string[] winter_holydays = { "1. Winter holyday", "2. Winter holyday", "3. Winter holyday" };
    string[] spring_holydays = { "1. Spring holyday", "2. Spring holyday", "3. Spring holyday" };
    
    Console.Write("Enter the season (summer, autumn, winter, spring): ");
    Seasons season = (Seasons)Array.IndexOf(seasons, Console.ReadLine());

    switch (season)
    {
        case Seasons.SUMMER:
            foreach (string holyday in summer_holydays)
            {
                Console.WriteLine(holyday);
            } break;
        case Seasons.AUTUMN:
            foreach (string holyday in autumn_holydays)
            {
                Console.WriteLine(holyday);
            } break;
        case Seasons.WINTER:
            foreach (string holyday in winter_holydays)
            {
                Console.WriteLine(holyday);
            } break;
        case Seasons.SPRING:
            foreach (string holyday in spring_holydays)
            {
                Console.WriteLine(holyday);
            } break;
    }
}

enum Marks
{
    VERY_BAD = 1,
    NOTSATISFACTORY,
    SATISFACTORY,
    GOOD,
    VERY_GOOD
}

enum Seasons
{
    SUMMER,
    AUTUMN,
    WINTER,
    SPRING
}

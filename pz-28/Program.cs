using pz_28;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the task (1/2): ");
        var task = Console.ReadLine();

        switch (task)
        {
            case "1":
                var student = new Student();
                var teacher = new Teacher(2.4, "You are stupid student...");

                student.OnAddMark += teacher.Warning;

                while (true)
                {
                    Console.Write("Enter the new mark: ");
                    student.AddMark(int.Parse(Console.ReadLine()));
                }

                break;

            case "2":
                var temperature = new Temperature();
                var temperatureMonitor = new TemperatureMonitor();

                temperature.OnTemperatureIncrease += temperatureMonitor.Info;

                while (temperature.Value <= 40)
                {
                    Console.WriteLine("Increasing a temperature...");
                    
                    temperature.Increment();
                    
                    Thread.Sleep(250);
                }

                break;
        }
    }
}



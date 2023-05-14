namespace pz_28;

public class TemperatureMonitor
{
    private string _message = "Temperature is {0}C";
    
    public TemperatureMonitor() {}

    public TemperatureMonitor(string message)
    {
        this._message = message;
    }
    
    public void Info(int temperature)
    {
        switch (temperature)
        {
            case -25:
                Console.WriteLine(_message, temperature.ToString());
                break;
            case 0:
                Console.WriteLine(_message, temperature.ToString());
                break;
            case 25:
                Console.WriteLine(_message, temperature.ToString());
                break;
            case 35:
                Console.WriteLine(_message, temperature.ToString());
                break;
        }
    }
}
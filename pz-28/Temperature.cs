namespace pz_28;

public class Temperature
{
    public int Value = -30;

    public delegate void TemperatureHandler(int temperature);
    public event TemperatureHandler? OnTemperatureIncrease;

    public void Increment()
    {
        this.Value++;
        OnTemperatureIncrease?.Invoke(Value);
    }
}
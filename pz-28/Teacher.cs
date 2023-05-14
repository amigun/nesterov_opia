namespace pz_28;

public class Teacher
{
    private double _criticalMark;
    private string _message;

    public Teacher(double criticalMark, string message)
    {
        this._criticalMark = criticalMark;
        this._message = message;
    }

    public void Warning(double mark)
    {
        if (mark == this._criticalMark)
        {
            Console.WriteLine(this._message);
        }
    }
}
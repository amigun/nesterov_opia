namespace pz_21;

public class Vector
{
    private int x;
    private int y;

    public Vector()
    {
        this.x = 0;
        this.y = 0;
    }

    public Vector(int x)
    {
        this.x = x;
        this.y = 0;
    }

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Vector({x}, {y})");
    }

    public Vector Multiple(int n)
    {
        return new Vector(this.x * n, this.y * n);
    }

    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
    }

    public double[] GetMiddle()
    {
        return new double[2] { this.x / 2, this.y / 2 };
    }
}
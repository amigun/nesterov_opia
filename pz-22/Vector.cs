namespace pz_22;

public class Vector
{
    private int _x, _y;

    public int X
    {
        get { return _x; }
        set
        {
            if (-100 <= value && value <= 100)
            {
                bool isVectorZero = IsZero(); 
                bool isLenLessThan10 = IsLengthLessThan10();
                
                _x = value;
                
                if (isVectorZero && value != 0)
                {
                    CountOfZeroVectors -= 1;
                } else if (IsZero())
                {
                    CountOfZeroVectors += 1;
                }
                
                if (isLenLessThan10 != IsLengthLessThan10())
                {
                    CountOfVectorsThatLessThan10 -= 1;
                }
            }
        }
    }
    
    public int Y
    {
        get { return _y; }
        set
        {
            if (-100 <= value && value <= 100)
            {
                bool isVectorZero = IsZero(); 
                bool isLenLessThan10 = IsLengthLessThan10();
                
                _y = value;

                if (isVectorZero && value != 0)
                {
                    CountOfZeroVectors -= 1;
                } else if (IsZero())
                {
                    CountOfZeroVectors += 1;
                }

                if (isLenLessThan10 != IsLengthLessThan10())
                {
                    CountOfVectorsThatLessThan10 -= 1;
                }
            }
        }
    }

    private static int CountOfVectors { get; set; } = 0;

    private static int CountOfZeroVectors { get; set; } = 0;

    private static int CountOfVectorsThatLessThan10 { get; set; } = 0;

    public Vector()
    {
        this.X = 0;
        this.Y = 0;

        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public Vector(int x)
    {
        this.X = x;
        this.Y = 0;
        
        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public Vector(int x, int y)
    {
        this.X = x;
        this.Y = y;
        
        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Vector({this.X}, {this.Y})");
    }

    public Vector Multiple(int n)
    {
        return new Vector(this.X * n, this.Y * n);
    }

    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
    }

    public double[] GetMiddle()
    {
        return new double[2] { this.X / 2, this.Y / 2 };
    }

    public bool IsZero()
    {
        return this.X == 0 && this.Y == 0;
    }

    public bool IsLengthLessThan10()
    {
        return this.GetLength() <= 10;
    }
    
    public static int GetCountOfVectors()
    {
        return CountOfVectors;
    }

    public static int GetCountOfZeroVectors()
    {
        return CountOfZeroVectors;
    }

    public static int GetCountOfVectorsThatLessThan10()
    {
        return CountOfVectorsThatLessThan10;
    }
}
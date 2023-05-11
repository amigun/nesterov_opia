namespace pz_23;

public class HorizontalVector : Vector
{
    public override int Y
    {
        get { return this._y; }
        set
        {
            if (value == 0)
            {
                this._y = value;
            }
        }
    }
    
    public HorizontalVector()
    {
        this.X = 0;
        this.Y = 0;

        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public HorizontalVector(int x)
    {
        this.X = x;
        this.Y = 0;
        
        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public HorizontalVector(int x, int y)
    {
        this.X = x;
        this.Y = 0;
        
        CountOfVectors += 1;
        if (this.IsZero()) CountOfZeroVectors += 1;
        if (this.IsLengthLessThan10()) CountOfVectorsThatLessThan10 += 1;
    }

    public override object Clone()
    {
        return new HorizontalVector(this.X, this.Y);
    }
}
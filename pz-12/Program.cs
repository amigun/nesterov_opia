class pz_12
{
    public static void Swap(ref int x, ref int y)
    {
        int z = x;
        x = y;
        y = z;
    }
    
    public static void Main(string[] args)
    {
        int A = 10, B = 13, C = 43, D = 314; 
        
        Swap(ref A, ref B);
        Swap(ref C, ref D);
        Swap(ref B, ref C);
        
        Console.WriteLine($"A = {A}\nB = {B}\nC = {C}\nD = {D}"); // 13 314 10 43
    }
}
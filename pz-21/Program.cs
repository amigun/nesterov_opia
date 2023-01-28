using pz_21;

Vector a = new Vector();
Vector b = new Vector(2);
Vector c = new Vector(3, 4);
Vector d = new Vector(2, 6);

a.PrintInfo();

b.Multiple(2).PrintInfo();

Console.WriteLine(c.GetLength());

double[] coords = d.GetMiddle();
Console.WriteLine($"x: {coords[0]}, y: {coords[1]}");
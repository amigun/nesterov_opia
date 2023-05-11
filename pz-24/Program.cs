using System.Security.Cryptography;
using pz_23;

Vector vec_1 = new Vector(2, 3);
Vector vec_2 = (Vector)vec_1.Clone();

vec_2.Y = 5;

HorizontalVector hvec_1 = new HorizontalVector(5);
HorizontalVector hvec_2 = (HorizontalVector)hvec_1.Clone();

hvec_2.X = 10;

Console.WriteLine(" === vec_1 === ");
vec_1.PrintInfo();
Console.WriteLine();

Console.WriteLine(" === vec_2 === ");
vec_2.PrintInfo();
Console.WriteLine();

Console.WriteLine(" === hvec_1 === ");
hvec_1.PrintInfo();
Console.WriteLine();

Console.WriteLine(" === hvec_2 === ");
hvec_2.PrintInfo();
Console.WriteLine();

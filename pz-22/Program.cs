using pz_22;

static void Print()
{
    Console.WriteLine($"\nКоличество\n\tвекторов: {Vector.GetCountOfVectors()}\n\tнулевых векторов: {Vector.GetCountOfZeroVectors()}\n");
}

Vector a = new Vector();
Vector b = new Vector(2);
Vector c = new Vector(30, 40);

Print();

Console.WriteLine("Делаем один из векторов нулевым...");
b.X = 0;

Print();

Console.WriteLine("Опять делаем его ненулевым...");
b.Y = 10;

Print();



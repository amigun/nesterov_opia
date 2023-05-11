using pz_27;

namespace pz_27;

internal struct Student
{
    public string name;
    public short group;
    public short[] ses = new short[5];

    public Student(string name, short group, short[] ses)
    {
        this.name = name;
        this.group = group;
        this.ses = ses;
    }
}

internal abstract class Program
{
    public static void Main(string[] args)
    {
        var stud1 = new Student[2];
        for (var i = 0; i < stud1.Length; i++)
        {
            Console.Write("Enter the name: ");
            var name = "Default";

            var nameString = Console.ReadLine();
            if (nameString is not null)
            {
                name = nameString;
            }
             
            Console.Write("Enter the group (a number, e.g. 1 or 2 or 3): ");
            var groupString = Console.ReadLine();

            var group = (short)1;
            if (groupString is not null)
            {
                group = short.Parse(groupString);
            }

            Console.Write("Enter the mark from 1 to 5, e.g. 2 or 5: ");
            var sesStrings = Console.ReadLine()?.Split();
            if (sesStrings == null) continue;
            var ses = new short[sesStrings.Length];
            
            for (var j = 0; j < sesStrings.Length; j++)
            {
                var mark = short.Parse(sesStrings[j]);

                ses[j] = mark;
            }

            stud1[i] = new Student(name, group, ses);
        }
         
        Array.Sort(stud1, (x, y) => x.group.CompareTo(y.group));

        foreach (var stud in stud1)
        {
            var goodStudentIsExist = false;
            
            if (Average(stud.ses) > 4.0)
            {
                goodStudentIsExist = true;
                Console.WriteLine($"Name: {stud.name}\tGroup: {stud.group}");
            } 
            
            if (!goodStudentIsExist)
            {
                Console.WriteLine("There are no students like that");
            }
        }
    }

    private static double Average(short[] array)
    {
        var sum = array.Aggregate((double)0, (current, elem) => current + elem);

        return sum / array.Length;
    }
}

//namespace Ch05Ex02
//{
//    enum Orientation : byte
//    {
//        north = 1,
//        south = 2,
//        east = 3,
//        west = 4
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Orientation myDirection = Orientation.north;
//            Console.WriteLine($"myDirection = {myDirection}");
//            Console.ReadKey();
//        }
//    }
//}


// Collect name, age, experience, => Salary

try
{
    Console.WriteLine("This is writeline ");
    Console.Write("This is write ");

    var name = Console.ReadLine();
    Console.WriteLine("Please enter your age: ");
    var age = Console.ReadLine();
    Console.WriteLine("Please enter your year of experience:");
    var experience = Convert.ToInt32(Console.ReadLine());

    // salary = (1000*8)*20*(years)
    var salary = (1000 * 8) * 20 * experience;
    Console.WriteLine($"Your name is {name}. \nYou're {age} years old. And your salary is ${salary} based on your year of experience which is {experience} year(s)");
}
catch (Exception ex)
{

    Console.WriteLine(ex);
}

// Write a program that will collect students name, grades for MAT, ENG, LIT, GOVT, CIVIC
// A >= 75, B>= 65, C>=55, D>= 50, E>=45, F <45

// Name: Akin Ade
// Results Breakdown.
// Eng - 75 - A
// Mat - 60 - C
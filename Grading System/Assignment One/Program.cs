
using Assignment_One;

Dictionary<string, Dictionary<string, int>> studentGrades = new Dictionary<string, Dictionary<string, int>>();

while (true)
{
    Console.Write("Enter your name or 'quit' to exit: ");
    string studentName = Console.ReadLine();

    if (studentName.ToLower() == "quit") break;

    Dictionary<string, int> grades = new Dictionary<string, int>();

    var subjects = new List<string>()
    {
        "Mathematics",
        "English",
        "Literature",
        "Government",
        "Civic Edu"
    };
    Console.WriteLine("========= Grading System =============");

    try
    {
        foreach (var subject in subjects)
        {
            Console.Write($"Enter score for {subject}: ");
            grades[subject] = Convert.ToInt32(Console.ReadLine());
        }
    }
    catch (Exception ex)
    {

        Console.Write($"An error has occurred. \n{ex}");
    }

    studentGrades.Add(studentName!, grades);
}

// Get response

foreach (var student in studentGrades)
{
    Console.WriteLine($"Student name : {student.Key} \n============= Grate Breakdown ============= \nSubject \t- \tScore \t- \tGrade");

    foreach (var sub in student.Value)
    {
        Console.WriteLine($"{sub.Key} \t- \t{sub.Value} \t- \t{Grade.getGrade(sub.Value)}");
    }
}

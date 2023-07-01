using GradingSys;

// Greeting message
Console.WriteLine("========== Grading System ==========");

// key - value pair 
Dictionary<string, Dictionary<string, int>> studentGrade = new Dictionary<string, Dictionary<string, int>>();

while (true)
{
    Console.Write("Enter your name or 'quit' to exit: ");
    string name = Console.ReadLine();

    if (name.ToLower() == "quit") break;

    Dictionary<string, int> grades = new Dictionary<string, int>();
    try
    {
        foreach (string subject in CONSTANT.subjects)
        {
            Console.Write($"Enter the score for {subject}: ");
            grades[subject] = Convert.ToInt32(Console.ReadLine());
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error has occurred. \n{ex.Message}");
    }


    // Save the data into studentGrade
    studentGrade.Add(name, grades);
}

// Final response
Console.WriteLine("========== Grade Result ==========");
foreach(var student in studentGrade)
{
    Console.WriteLine($"Student Name: {student.Key} \nSTUDENT'S GRADE \nSubject \t- \tScore \t- \tGrade");
    foreach(var subject in student.Value)
    {
        Console.WriteLine($"{subject.Key} \t- \t{subject.Value} \t- \t{Grade.GetGrade(subject.Value)}");
    }
}

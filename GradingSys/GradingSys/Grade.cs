namespace GradingSys
{
    public class Grade
    {
        // Our first method
        public static char GetGrade(int score)
        {
            if (score >= 0 && score <= 100)
            {
                if (score >= 75) return 'A';
                else if (score >= 65) return 'B';
                else if (score >= 55) return 'C';
                else if (score >= 50) return 'D';
                else if (score >= 45) return 'E';
                else return 'F';

            }
            else throw new Exception("Invalid inputs");
        }
    }
}

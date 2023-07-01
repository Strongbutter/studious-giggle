namespace Assignment_One
{
    public static class Grade
    {
        public static char getGrade(int grade)
        {
            if (grade > 0 && grade <= 100)
            {
                if (grade >= 70) return 'A';
                else if (grade >= 65) return 'B';
                else if (grade >= 55) return 'C';
                else if (grade >= 50) return 'D';
                else if (grade >= 45) return 'E';
                else return 'F';
            }

            else return ' ';

        }
    }
}

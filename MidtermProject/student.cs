namespace MidtermProject
{
    public enum Status
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }

    public class Student
    {
        private string firstName;
        private string lastName;
        private string major;
        private int creditHours;
        private double score1;
        private double score2;
        private double score3;
        private Status classStatus;

        public Student(string firstName, string lastName, string major, int creditHours, double score1, double score2, double score3)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
            this.creditHours = creditHours;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            classStatus = GetClassStatus(creditHours);
        }

        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public string GetMajor() => major;
        public int GetCreditHours() => creditHours;

        public void SetFirstName(string firstName) => this.firstName = firstName;
        public void SetLastName(string lastName) => this.lastName = lastName;
        public void SetMajor(string major) => this.major = major;

        public Status GetClassStatus()
        {
            return classStatus;
        }

        public void AddCreditHours(int hours)
        {
            creditHours += hours;
            classStatus = GetClassStatus(creditHours);
        }

        public string GetFullName() => $"{firstName} {lastName}";

        public double GetAverageScore() => (score1 + score2 + score3) / 3;

        public char GetLetterGrade()
        {
            double average = GetAverageScore();
            if (average >= 90) return 'A';
            if (average >= 80) return 'B';
            if (average >= 70) return 'C';
            if (average >= 60) return 'D';
            return 'F';
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"{GetFullName()}: {classStatus}({major})");
            Console.WriteLine($"Average Score: {GetAverageScore()}% -- Grade: {GetLetterGrade()}");
        }

        private Status GetClassStatus(int creditHours)
        {
            if (creditHours < 30) return Status.Freshman;
            if (creditHours < 60) return Status.Sophomore;
            if (creditHours < 90) return Status.Junior;
            return Status.Senior;
        }
    }
}

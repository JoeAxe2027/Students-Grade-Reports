namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("student_data.csv").Skip(1);

            using (StreamWriter writer = new StreamWriter("report.txt"))
            {
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    var student = new Student(parts[0], parts[1], parts[3], int.Parse(parts[2]), double.Parse(parts[4]), double.Parse(parts[5]), double.Parse(parts[6]));
                    writer.WriteLine($"{student.GetFullName()}: {student.GetClassStatus()}({student.GetMajor()})");
                    writer.WriteLine($"Average Score: {student.GetAverageScore()}% Grade: {student.GetLetterGrade()}");
                    writer.WriteLine();
                    student.PrintStudentInfo();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Report generated successfully in report.txt");
        }
    }
}

using System.Text.Json;

class Student
{
    public string Name { get; set; }
    public int ListNumber { get; set; }
    public double Grade { get; set; }

    public Student(string name, int listNumber, double grade)
    {
        Name = name;
        ListNumber = listNumber;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"Name: {Name}, List Number: {ListNumber}, Grade: {Grade}";
    }
}

class Program
{
    static List<Student> students = new List<Student>();
    static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "students.json");

    static void Main()
    {
        LoadStudents();

        while (true)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student by list number");
            Console.WriteLine("4. Update student grade");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchAndDisplayStudent();
                    break;
                case 4:
                    ChangeStudentGrade();
                    break;
                case 5:
                    SaveStudents();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter list number: ");
        if (!int.TryParse(Console.ReadLine(), out int listNumber))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Console.Write("Enter grade: ");
        if (!double.TryParse(Console.ReadLine(), out double grade))
        {
            Console.WriteLine("Please enter a valid grade.");
            return;
        }

        students.Add(new Student(name, listNumber, grade));
        Console.WriteLine("Student added successfully.");
    }

    static void ViewStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    static void SearchAndDisplayStudent()
    {
        Console.Write("Enter list number: ");
        if (!int.TryParse(Console.ReadLine(), out int listNumber))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        var student = SearchStudentByListNumber(listNumber);
        if (student != null)
        {
            Console.WriteLine(student);
        }
        else
        {
            Console.WriteLine("Student with entered list number doesn't exist.");
        }
    }

    static Student SearchStudentByListNumber(int listNumber)
    {
        return students.Find(x => x.ListNumber == listNumber);
    }

    static void ChangeStudentGrade()
    {
        Console.Write("Enter student list number: ");
        if (!int.TryParse(Console.ReadLine(), out int listNumber))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Console.Write("Enter new grade: ");
        if (!double.TryParse(Console.ReadLine(), out double newGrade))
        {
            Console.WriteLine("Please enter a valid grade.");
            return;
        }

        var student = SearchStudentByListNumber(listNumber);
        if (student != null)
        {
            student.Grade = newGrade;
            Console.WriteLine("Grade changed successfully.");
        }
        else
        {
            Console.WriteLine("Student with entered list number doesn't exist.");
        }
    }

    static void SaveStudents()
    {
        string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        Console.WriteLine("Students saved successfully.");
    }

    static void LoadStudents()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            students = JsonSerializer.Deserialize<List<Student>>(json);
            Console.WriteLine("Students loaded successfully.");
        }
    }
}

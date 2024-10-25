using System;

public class Student
{
    public int ID { get; set; } // Unique ID for each student
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Course { get; set; }

    // Constructor to initialize student data
    public Student(int id, string firstName, string lastName, DateTime dateOfBirth, string course)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Course = course;
    }

    // Optional: Override ToString method to display student details easily
    public override string ToString()
    {
        return $"{ID}: {FirstName} {LastName}, DOB: {DateOfBirth.ToShortDateString()}, Course: {Course}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ask for user input to create a new student
        Console.WriteLine("Enter Student ID:");
        int id = int.Parse(Console.ReadLine()); // Read and convert input to integer

        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Date of Birth (yyyy-mm-dd):");
        DateTime dateOfBirth;
        while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth)) // Validate date input
        {
            Console.WriteLine("Invalid date. Please enter a valid date in the format yyyy-mm-dd:");
        }

        Console.WriteLine("Enter Course:");
        string course = Console.ReadLine();

        // Create the Student object with user input
        Student student = new Student(id, firstName, lastName, dateOfBirth, course);

        // Display the student details
        Console.WriteLine("Student details entered successfully:");
        Console.WriteLine(student.ToString());
    }
}

namespace COnsoleApp3;

using System;
using System.Collections.Generic;

// Abstraction & Encapsulation
public abstract class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value >= 0 ? value : throw new ArgumentException("Salary cannot be negative"); }
    }

    public List<string> Addresses { get; private set; } = new List<string>();

    public Person(string name, DateTime dateOfBirth)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    // Polymorphism: Virtual method
    public virtual decimal CalculateSalary() => Salary;

    public int CalculateAge() => DateTime.Now.Year - DateOfBirth.Year;

    public void AddAddress(string address) => Addresses.Add(address);
}

public class Student : Person
{
    public List<Course> Courses { get; private set; } = new List<Course>();

    public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth) { }

    public void EnrollInCourse(Course course) => Courses.Add(course);
    
    // Polymorphism: Override method
    public override decimal CalculateSalary() => 0; // Students don't earn a salary in this context
}

public class Instructor : Person
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }

    public Instructor(string name, DateTime dateOfBirth, Department department, DateTime joinDate) 
        : base(name, dateOfBirth)
    {
        Department = department;
        JoinDate = joinDate;
    }

    // Polymorphism: Override method
    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        // Added bonus salary based on experience
        return base.CalculateSalary() + (yearsOfExperience * 1000); 
    }
}

public class Course
{
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; private set; } = new List<Student>();

    public void EnrollStudent(Student student) => EnrolledStudents.Add(student);
}

public class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; private set; } = new List<Course>();
}

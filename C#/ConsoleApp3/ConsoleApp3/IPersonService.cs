namespace COnsoleApp3;

public interface IPersonService
{
    void AddPerson(Person person);
    Person GetPerson(string name);
}

public interface IStudentService : IPersonService
{
    void EnrollStudentInCourse(Student student, Course course);
}

public interface IInstructorService : IPersonService
{
    void AssignInstructorToDepartment(Instructor instructor, Department department);
}
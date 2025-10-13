namespace cw4_class;

public class Student{
    private string firstName;
    private string lastName;
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
    public Student()
    {
        firstName = "John";
        lastName = "Doe";
    }
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    //properties
    public string FirstName
    {
        get { return firstName.ToUpper(); }
        set { firstName = value.Trim(); }
    }
    public string LastName
    {
        get { return lastName.ToUpper(); }
        set { lastName = value.Trim(); }
    }
}
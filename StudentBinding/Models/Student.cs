namespace StudentBinding.Models;

public class Student : ObservableObject
{
   
    private string name;
    private string surname;
    private int age;
    private string email;
    private string profilePicture;
    private DateTime dateOfBirth;

    private string phone;

    public Student(string name, string surname, string email, string profilePicture, DateTime dateOfBirth, string phone)
    {
        Name = name;
        Surname = surname;
        Email = email;
        ProfilePicture = profilePicture;
        DateOfBirth = dateOfBirth;
        Phone = phone;
    }

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public string Phone
    {
        get { return phone; }
        set
        {
            phone = value;
            OnPropertyChanged(nameof(Phone));
        }
    }

    public string Surname
    {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged(nameof(Surname));
        }
    }

    public int Age
    {
        get
        {
            int age_student = DateTime.Now.Subtract(dateOfBirth).Days / 365;
            return age_student;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    public string ProfilePicture
    {
        get { return profilePicture; }
        set
        {
            profilePicture = value;
            OnPropertyChanged(nameof(ProfilePicture));
        }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set
        {
            dateOfBirth = value;
            OnPropertyChanged(nameof(DateOfBirth));
            OnPropertyChanged(nameof(Age));
        }
    }
}
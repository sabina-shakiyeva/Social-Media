namespace social_media;

public class User
{
    public User(int ıd, string name, string surname, int age, string email, string password)
    {
        Id = ıd;
        Name = name;
        Surname = surname;
        Age = age;
        Email = email;
        Password = password;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}
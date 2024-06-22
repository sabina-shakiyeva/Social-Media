namespace social_media;

public class Notification
{
    public Notification(int ıd, string text, DateTime dateTime, User fromUser)
    {
        Id = ıd;
        Text = text;
        DateTime = dateTime;
        FromUser = fromUser;
    }

    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime DateTime { get; set; }
    public User FromUser { get; set; }
}
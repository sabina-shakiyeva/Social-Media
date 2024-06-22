namespace social_media;

public class Admin
{
    public Admin(int ıd, string username, string email, string password, List<Post> posts, List<Notification> notifications)
    {
        Id = ıd;
        Username = username;
        Email = email;
        Password = password;
        Posts = posts;
        Notifications = notifications;
    }

    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    List<Post> Posts { get; set; }
    List<Notification> Notifications { get; set; }
    public void SendNotification(Notification notification)
    {
        Notifications.Add(notification);
        Console.WriteLine(notification.Text);
    }
    public void ShowNotifications()
    {
        Console.WriteLine("Notifications:");
        foreach (var notification in Notifications)
        {
            Console.WriteLine($"ID: {notification.Id}, Text: {notification.Text}, DateTime: {notification.DateTime}, FromUser: {notification.FromUser?.Name}");
        }
    }

}
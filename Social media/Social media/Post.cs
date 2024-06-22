namespace social_media;

public class Post
{
    public Post(int ıd, string content, DateTime creationDateTime, int likeCount, int viewCount)
    {
        Id = ıd;
        Content = content;
        CreationDateTime = creationDateTime;
        LikeCount = likeCount;
        ViewCount = viewCount;
    }

    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreationDateTime { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }

    public void Like(Admin admin, User user)
    {
        LikeCount++;
        Notify(admin, user, "liked");

    }
    public void View(Admin admin, User user)
    {
        ViewCount++;
        Notify(admin, user, "viewed");

    }
    public void Notify(Admin admin, User user, string action)
    {
        var notification = new Notification
        (
            ıd:new Random().Next(1, 1000),
            text : $"Post was {action}",
            dateTime : DateTime.Now,
            fromUser : user
        );
        admin.SendNotification( notification );
    }
}
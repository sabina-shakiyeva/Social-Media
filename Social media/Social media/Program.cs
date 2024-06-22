using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using social_media;

class Program
{
   
    static void Main(string[] args)
    {
        List<Admin> admins = new List<Admin>();
        List<User> users = new List<User>();
        List<Post> posts = new List<Post>();
        List<Notification> notifications = new List<Notification>();
        Admin admin1 = new Admin(1, "sabina", "shakiyeva@gmail.com", "1234", posts, notifications);
        admins.Add(admin1);

        User user1 = new User(1, "Lale", "Aliyeva", 25, "fuad@gmail.com", "2345");
        users.Add(user1);

        Post post1 = new Post(1, "agac sekli", new DateTime(2023, 2, 3), 5, 6);
        posts.Add(post1);

        Notification notification = new Notification(1, "Message", DateTime.Now, user1);
        while (true)
        {
            Console.WriteLine("Admin yoxsa user olaraq daxil olacaqsiz?");
            int choice = 0;
            Console.Write("Admin ucun 1 User ucun 2 duymesini sixin:");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter username:");
                string username = Console.ReadLine();
                Console.Write("Enter password:");
                string password = Console.ReadLine();
                foreach (Admin admin in admins)
                {
                    if (admin.Username != username & admin.Password != password)
                    {
                        Console.WriteLine("Ad ve ya sifre yanlisdir");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("1) show notifications 2) Exit");
                            int choiceAdmin = int.Parse(Console.ReadLine());
                            if (choiceAdmin == 1)
                            {
                                //ShowNotifications();
                                foreach (Admin admin2 in admins)
                                {
                                    admin2.ShowNotifications();
                                }

                            }
                            else if (choiceAdmin == 2)
                            {
                                break;
                            }


                        }
                    }
                }

            }
            else if (choice == 2)
            {
                Console.Write("Enter username:");
                string username = Console.ReadLine();
                Console.Write("Enter password:");
                string password = Console.ReadLine();
                foreach (User user in users)
                {
                    if (user.Name != username & user.Password != password)
                    {
                        Console.WriteLine("Ad ve ya sifre yanlisdir");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("1) show posts 2)View Post 3) Like post 4)Exit");
                            int choiceUser = int.Parse(Console.ReadLine());
                            if (choiceUser == 1)
                            {
                                foreach (var post in posts)
                                {
                                    Console.WriteLine($"ID: {post.Id}, Content: {post.Content}, Likes: {post.LikeCount}, Views: {post.ViewCount}");
                                }

                            }
                            else if (choiceUser == 2)
                            {
                                Console.WriteLine("Enter post Id for view:");
                                int postId = int.Parse(Console.ReadLine());
                                foreach (var post in posts)
                                {
                                    if (postId == post.Id)
                                    {
                                        post.View(admin1, user);
                                        Console.WriteLine("Post viewed");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found");
                                    }
                                }

                            }
                            else if (choiceUser == 3)
                            {
                                Console.WriteLine("Enter post Id for like:");
                                int postId = int.Parse(Console.ReadLine());
                                foreach (var post in posts)
                                {
                                    if (postId == post.Id)
                                    {
                                        post.Like(admin1, user);
                                        Console.WriteLine("Post liked");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found");
                                    }
                                }

                            }
                            else if (choiceUser == 4)
                            {
                                break;
                            }


                        }
                    }
                }



            }

        }
      

        
     

    }

}
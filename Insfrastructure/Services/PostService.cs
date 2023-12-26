using Domain.Models;

namespace Insfrastructure.Services;

public class PostService
{
    List<Post> p1 = new List<Post>();
    public List<Post> GetPosts()
    {
        return p1;
    }
    public void AddPost(Post post)
    {
        p1.Add(post);
    }
    public string UpdatePost(int id, DateTime created)
    {
        foreach (var post in p1)
        {
            if (post.Id == id)
            {
                post.CreatedAt = created;
                System.Console.WriteLine("Post successfully updated");
            }
        }
        return "Group not found";
    }

     public string Delete(int id)
    {
        foreach (var pos in p1)
        {
            if (pos.Id == id)
            {
                p1.Remove(pos);
                return "Group deleted successfully";
            }
        }
        return "Group not found";
    }
    
}

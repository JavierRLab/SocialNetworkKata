namespace SocialNetworkKata;

public interface IPostRepository
{
    IEnumerable<Post> GetTimeline(string username);
}

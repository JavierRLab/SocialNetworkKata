namespace SocialNetworkKata.Tests;

public class PostRepository : IPostRepository
{
    public IEnumerable<Post> GetTimeline(string username) =>
        throw new NotImplementedException();
}

using Moq;

namespace SocialNetworkKata.Tests;

public class SocialNetworkShould
{
    [Fact(DisplayName = "Store a message for a user")]
    public void Test1()
    {
        var repo = new Mock<IPostRepository>();
        var sn = new SocialNetwork(repo.Object);
        var postTime = DateTime.UtcNow;
        sn.Execute("Simon -> Jump on one leg.");
        var simonTmln = repo.Object.GetTimeline("Simon").ToArray();
        Assert.Single(simonTmln);
        Assert.Equal(new Post("Simon", "Jump on one leg.", postTime), simonTmln.First());
    }
}

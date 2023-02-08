using Moq;

namespace SocialNetworkKata.Tests;

public class SocialNetworkShould
{
    [Fact(DisplayName = "Store a message for a user")]
    public void Test1()
    {
        var postTime = DateTime.UtcNow;
        var expected = new Post("Simon", "Jump on one leg.", postTime);

        var repo = new Mock<IPostRepository>();
        var clock = new Mock<IClock>();

        clock.Setup(c => c.UtcNow).Returns(postTime);

        new SocialNetwork(repo.Object, clock.Object)
            .Execute("Simon -> Jump on one leg.");
        
        repo.Verify(r => r.Add(expected), Times.Once);
    }
}

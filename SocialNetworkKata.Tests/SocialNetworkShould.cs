using Moq;

namespace SocialNetworkKata.Tests;

public class SocialNetworkShould
{
    [Fact(DisplayName = "Store a message for a user")]
    public void Test1()
    {
        var postTime = DateTime.UtcNow;
        var randomUserName = Guid.NewGuid().ToString();
        var randonMessage = Guid.NewGuid().ToString();
        var expected = new Post(randomUserName, randonMessage, postTime);

        var repo = new Mock<IPostRepository>();
        var clock = new Mock<IClock>();

        clock.Setup(c => c.UtcNow).Returns(postTime);

        new SocialNetwork(repo.Object, clock.Object)
            .Execute($"{randomUserName} -> {randonMessage}");

        repo.Verify(r => r.Add(expected), Times.Once);
    }
}

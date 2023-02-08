using Moq;

namespace SocialNetworkKata.Tests;

public class SocialNetworkShould
{
    [Fact(DisplayName = "Store a message for a user")]
    public void Test1()
    {
        var postTime = DateTime.UtcNow;
        var randomUserName = Guid.NewGuid().ToString();
        var randomMessage = Guid.NewGuid().ToString();
        var expected = new Post(randomUserName, randomMessage, postTime);

        var repo = new Mock<IPostRepository>();
        var clock = new Mock<IClock>();
        var parser = new Mock<ICommandParser>();

        clock.Setup(c => c.UtcNow).Returns(postTime);
        parser
            .Setup(c => c.Parse($"{randomUserName} -> {randomMessage}"))
            .Returns(new Command(randomUserName, randomMessage));

        new SocialNetwork(repo.Object, clock.Object, parser.Object)
            .Execute($"{randomUserName} -> {randomMessage}");

        repo.Verify(r => r.Add(expected), Times.Once);
    }
}

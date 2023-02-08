namespace SocialNetworkKata.Tests;

public class AcceptanceTests
{
    [Fact(DisplayName = "when posting as bob, I can see what bob just posted")]
    public void Test1()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);
        var sn = new SocialNetwork();
        sn.Execute("bob -> I think, therefore I err");
        sn.Execute("bob");
        Assert.Equal("I think, therefore I err (1 minute ago)\n", writer.ToString());
    }
}

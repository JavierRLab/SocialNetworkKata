namespace SocialNetworkKata.Tests;

public class CommandParserShould
{
    [Fact(DisplayName = "parse a string published message into a command object")]
    public void Test1()
    {
        string randomUsername = Guid.NewGuid().ToString();
        string randomMessage = Guid.NewGuid().ToString();
        string command = $"{randomUsername} -> {randomMessage}";
        
        var actualCmd = new CommandParser().Parse(command);
        var expectedCmd = new Command(randomUsername, randomMessage);
        
        Assert.Equal(expectedCmd, actualCmd);
    }
}
namespace SocialNetworkKata;

public class CommandParser : ICommandParser
{
    public Command Parse(string command)
    {
        var strings = command.Split(" -> ");
        var username = strings[0];
        var message = strings[1];
        return new(username, message);
    }
}

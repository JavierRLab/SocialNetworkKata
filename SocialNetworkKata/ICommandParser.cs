namespace SocialNetworkKata;

public interface ICommandParser
{
    Command Parse(string command);
}

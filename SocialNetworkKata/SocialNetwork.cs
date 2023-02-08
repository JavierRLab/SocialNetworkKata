namespace SocialNetworkKata;

public class SocialNetwork
{
    private readonly IPostRepository repository;
    private readonly IClock clock;
    private readonly ICommandParser commandParser;

    public SocialNetwork(IPostRepository repository, IClock clock, ICommandParser commandParser)
    {
        this.repository = repository;
        this.clock = clock;
        this.commandParser = commandParser;
    }

    public void Execute(string command)
    {
        var cmd = commandParser.Parse(command);
        repository.Add(new Post(cmd.Username, cmd.Message, clock.UtcNow));
    }
}

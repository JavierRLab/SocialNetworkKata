namespace SocialNetworkKata;

public class SocialNetwork
{
    private readonly IPostRepository repository;
    private readonly IClock clock;

    public SocialNetwork(IPostRepository repository, IClock clock)
    {
        this.repository = repository;
        this.clock = clock;
    }

    public void Execute(string commad)
    {
        repository.Add(new Post("Simon", "Jump on one leg.", clock.UtcNow));
    }
}

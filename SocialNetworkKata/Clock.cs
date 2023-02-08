namespace SocialNetworkKata;

public class Clock : IClock
{
    public DateTime UtcNow => DateTime.UtcNow;
}

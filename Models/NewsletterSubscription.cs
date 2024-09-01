namespace NewsletterApi.Models
{
    public class NewsletterSubscription
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
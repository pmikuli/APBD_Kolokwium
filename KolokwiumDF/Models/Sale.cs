using System.ComponentModel.DataAnnotations;

namespace KolokwiumDF.Models;

public class Sale
{
    [Key]
    public int IdSale { get; set; }
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public Subscription Subscription { get; set; }
    public Client Client { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace KolokwiumDF.Models;

public class Subscription
{
    [Key]
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public DateTime EndTime { get; set; }
    public int Price { get; set; }
    
    public virtual ICollection<Sale> Sales { get; set; }
}
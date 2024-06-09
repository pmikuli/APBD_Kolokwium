using System.ComponentModel.DataAnnotations;

namespace KolokwiumDF.Models;

public class Client
{
    [Key]
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public virtual ICollection<Discount> Discounts { get; set; }
    public virtual ICollection<Sale> Sales { get; set; }
}
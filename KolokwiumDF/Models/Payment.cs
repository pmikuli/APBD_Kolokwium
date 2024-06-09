using System.ComponentModel.DataAnnotations;

namespace KolokwiumDF.Models;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }
    public DateTime Date { get; set; }
    public int IdClient { get; set; }
    public int IdSubcription { get; set; }
}
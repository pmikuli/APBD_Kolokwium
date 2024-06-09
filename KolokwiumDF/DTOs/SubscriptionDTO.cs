namespace KolokwiumDF.DTOs;

public class SubscriptionDTO
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public int TotalAmountPaid { get; set; }
}
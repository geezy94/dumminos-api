public class Billing
{
    public int BillingId { get; set; }
    public int OrderId { get; set; }
    public float TotalCost { get; private set; }
    public PaymentMethod Payment { get; private set; }
    public string CouponCode { get; set; }
    public float Discount { get; private set; }
}


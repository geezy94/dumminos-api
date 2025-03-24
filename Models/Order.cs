public class Order
{
    public int OrderId { get; set; }
    public List<Menu> Orders { get; set; } = new List<Menu>();
    public Billing FinalBill { get; set; } = new Billing();
}
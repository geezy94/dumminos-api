public class DummyCustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<DeliveryLocation> AddressBook { get; set; }
    public int PrimaryMobile { get; set; }
    public int SecondaryMobile { get; set; }
    public DateTime JoinedDate { get; set; }
}

public class Outlet
{
    public int OutletNumber { get; set; }
    public string Address { get; set; }
    public int PinCode { get; set; }
    public DummyEmployee OutletManager { get; set; }
    public DummyEmployee OutletSupervisor { get; set; }
    public List<DummyEmployee> Warriors { get; set; }
    public DummyEmployee LegalAdvisor { get; set; }
}
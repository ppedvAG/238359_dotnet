namespace HalloAspMVC.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; } =string.Empty;
        public decimal Price { get; set; }
        public int KCal { get; set; }
    }
}

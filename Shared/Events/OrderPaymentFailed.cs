namespace Shared.Events
{

    public class OrderPaymentFailed
    {
        public int OrderId { get; set; }
        public Dictionary<int, int> Items { get; set; } // Id, Quantity

    }
}

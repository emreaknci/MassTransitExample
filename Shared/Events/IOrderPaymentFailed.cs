namespace Shared.Events
{
    public interface IOrderPaymentFailed
    {
        public int OrderId { get;  }
        public Dictionary<string, int> Items { get;  } // ProductName, Quantity

    }
    public class OrderPaymentFailed: IOrderPaymentFailed
    {
        public int OrderId { get; set; }
        public Dictionary<string, int> Items { get; set; } // ProductName, Quantity

    }
}

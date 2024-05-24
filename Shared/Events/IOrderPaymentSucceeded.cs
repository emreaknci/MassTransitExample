namespace Shared.Events
{
    public interface IOrderPaymentSucceeded
    {
        public int OrderId { get; set; }

    }

    public class OrderPaymentSucceeded : IOrderPaymentSucceeded
    {
        public int OrderId { get; set; }
    }
}

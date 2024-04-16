namespace GestionHotel.Apis.Constants
{
    public static class Class
    {
        public enum PaymentMethod
        {
            None = 0,
            CreditCard = 1,
            Cash = 2,
            PayPal = 3,
            Stripe = 4
        }

        public enum PaymentStatus
        {
            Pending = 0,
            Paid = 1
        }

        public enum CancellationStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2,
            Cancelled = 3,
            Refunded = 4
        }

        public enum RoomStatus
        {
            Free = 0,
            Occupied = 1,
            Unavailable = 2,
        }
    }
}

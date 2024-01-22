namespace Examen1
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Introduceți numele clientului: ");
            string customer = Console.ReadLine();

            Console.Write("Introduceți data comenzii (YYYY-MM-DD): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Introduceți valoarea totală a comenzii: ");
            decimal total = decimal.Parse(Console.ReadLine());

            Order order = new Order
            {
                Customer = customer,
                Date = date,
                Total = total
            };

            
            Console.Write("Introduceți metoda de plată aleasă (Card/PayPal/CryptoWallet): ");
            string paymentMethod = Console.ReadLine();

            
            IPaymentSystem paymentSystem;

            switch (paymentMethod.ToLower())
            {
                case "card":
                    paymentSystem = new CardPaymentSystem();
                    break;
                case "paypal":
                    paymentSystem = new PayPalPaymentSystem();
                    break;
                case "cryptowallet":
                    paymentSystem = new CryptoWalletPaymentSystem();
                    break;
                default:
                    Console.WriteLine("Metoda de plată introdusă nu este validă.");
                    return;
            }

 
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.FulfillOrder(order, paymentSystem);
        }
    }
}
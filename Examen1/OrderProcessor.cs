using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
public class OrderProcessor
{
    public void FulfillOrder(Order order, IPaymentSystem paymentSystem)
    {
        Console.WriteLine($"Comanda pentru {order.Customer} în valoare de {order.Total} RON, datată la {order.Date}, a fost procesată:");
        paymentSystem.ProcessPayment(order.Total);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
public class Order
{
    public string Customer { get; set; }
    public DateTime Date { get; set; }
    public decimal Total { get; set; }
}

public interface IPaymentSystem
{
    void ProcessPayment(decimal amount);
}


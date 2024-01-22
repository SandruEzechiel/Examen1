using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
public abstract class PaymentSystem : IPaymentSystem
{
    public abstract void ProcessPayment(decimal amount);
}

public class CardPaymentSystem : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata online cu cardul în valoare de {amount} RON a fost efectuată.");
    }
}

public class PayPalPaymentSystem : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata prin PayPal în valoare de {amount} RON a fost efectuată.");
    }
}

public class CryptoWalletPaymentSystem : PaymentSystem
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Plata cu wallet crypto în valoare de {amount} RON a fost efectuată.");
    }
}
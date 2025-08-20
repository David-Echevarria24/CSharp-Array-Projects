using System.Collections;

namespace DataTypes8;

class Program
{
    static void Main(string[] args)
    {
        OrderStatus currentStatus = OrderStatus.Processing;
        Console.WriteLine("currentStatus order status " + currentStatus);

        switch (currentStatus)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Order has not been processed");
                break;
            case OrderStatus.Processing:

                break;
            case OrderStatus.Shipped:

                break;
        }
    }
}

enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}
using System;
using enums.Ex1Entities;


class executor{
    public static void Main(){
         Order order = new Order{
            Id=10,
            Moment = DateTime.Now,
            status = OrderStatus.PendingPayments
        };
        Console.WriteLine(order);

        // enum to string
        string teste = OrderStatus.Delivered.ToString();
        Console.WriteLine(teste);

        // string to enum
        OrderStatus ord = Enum.Parse<OrderStatus>("Delivered");
        Console.WriteLine(ord);

    }

}


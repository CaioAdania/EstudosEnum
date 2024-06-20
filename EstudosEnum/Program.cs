using EstudosEnum.Entities;
using EstudosEnum.Entities.Enums;

namespace EstudosEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayments
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayments.ToString(); //conversão de enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //conversão de string para enum

            Console.WriteLine(os);

            Console.WriteLine(txt);
        }
    }
}
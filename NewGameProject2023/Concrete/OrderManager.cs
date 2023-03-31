using NewGameProject2023.Abstract;
using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Add(Orders orders, Gamers gamers)
        {
            Console.WriteLine(orders.OrderName + gamers.FirstName + " Added");
        }

        public void Delete(Orders orders, Gamers gamers)
        {
            Console.WriteLine(orders.OrderName + gamers.FirstName + " Deleted");
        }

        public void Update(Orders orders, Gamers gamers)
        {
            Console.WriteLine(orders.OrderName + gamers.FirstName + " Updated");
        }
    }
}

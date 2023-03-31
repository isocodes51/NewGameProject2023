using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Abstract
{
    public interface IOrderService
    {
        void Add(Orders orders, Gamers gamers);
        void Update(Orders orders, Gamers gamers);
        void Delete(Orders orders, Gamers gamers);

    }
}

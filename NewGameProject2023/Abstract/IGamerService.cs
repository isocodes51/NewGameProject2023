using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Abstract
{
    public interface IGamerService
    {
        void Add(Gamers gamer);
        void Update(Gamers gamer);
        void Delete(Gamers gamer);

    }
}

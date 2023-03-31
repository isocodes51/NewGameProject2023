using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Abstract
{
    public interface IGamesService
    {
        void Add(Games games);
        void Update(Games games);

        void Delete(Games games);
    }
}

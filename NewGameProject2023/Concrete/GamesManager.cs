using NewGameProject2023.Abstract;
using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Concrete
{
    public class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games+" Added");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games + " Updated");
        }

        public void Update(Games games)
        {
            Console.WriteLine(games + " Deleted");
        }
    }
}

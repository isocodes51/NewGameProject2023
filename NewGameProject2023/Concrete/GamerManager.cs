using NewGameProject2023.Abstract;
using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Concrete
{
    public class GamerManager : IGamerService
    {
        public bool NationalityCheck(Gamers gamer)
        {
            return true;
        }
        public void Add(Gamers gamer)
        {
            
            if(NationalityCheck(gamer))
             Console.WriteLine(gamer.FirstName +" added");
            else
            {
                throw new Exception("Nationality Checked False");
            }
             
        }

      

        public void Delete(Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted");
        }

        

        public void Update(Gamers gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated");
        }

       
    }
}

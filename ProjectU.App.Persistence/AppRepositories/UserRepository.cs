 using System.Collections.Generic;
using ProjectU.App.Domain;
using System.Linq;
using System;
 
namespace ProjectU.App.Persistence.AppRepositories
{
    public class UserRepository
    {
        List<User> User;
 
    public UserRepository()
        {
            User= new List<User>()
            {
                new User{id=1,Name="Jhon",LastName= "Gonzalez",Address= "cra 34",Phone= 310667895},
                new User{id=1,Name="Camilo",LastName= "Perez",Address= "cra 85",Phone= 8756254},
                new User{id=1,Name="Yesica",LastName= "Mendoza",Address= "cll 12",Phone= 3006594785}
 
            };
        }
 
        public IEnumerable<User> GetAll()
        {
            return User;
        }
 
        public User GetUserWithId(int id){
            return User.SingleOrDefault(b => b.id == id);
        }
    }
}

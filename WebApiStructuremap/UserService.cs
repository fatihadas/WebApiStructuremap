using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiStructuremap
{
    public class UserService : IUserService
    {
        public List<string> GetUserFullNames()
        {
            return new List<string> { "Fatih ADAŞ", "Anıl Boynueğri", "Emre Aydın", "Kadir Akyıldız", "Enver Yıldırım" };
        }
    }

}
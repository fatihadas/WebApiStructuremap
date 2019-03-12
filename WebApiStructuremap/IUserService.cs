using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiStructuremap
{
    public interface IUserService
    {
        List<string> GetUserFullNames();
    }
}
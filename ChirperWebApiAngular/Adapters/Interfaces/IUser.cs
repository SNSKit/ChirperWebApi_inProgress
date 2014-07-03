using ChirperWebApiAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChirperWebApiAngular.Adapters.Interfaces
{
    public interface IUser
    {
        UserVM GetUser(int id);
        List<UserVM> GetListUsers();
        List<FollowerVM> GetFollowers(int id);
    }
}

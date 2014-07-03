using Chirper.Data;
using Chirper.Data.Models;
using ChirperWebApiAngular.Adapters.Interfaces;
using ChirperWebApiAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChirperWebApiAngular.Adapters.Adapters
{
    public class UserAdapter : IUser
    {
        public UserVM GetUser(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            UserVM user = db.Users.Where(u => u.Id == id).Select(
                u => new UserVM { 
                    UserName = u.UserName,
                    Name = u.Name,
                    Email = u.Email,
                    Image = u.Image
                    
                }).FirstOrDefault();
            return user;
        }
        public List<UserVM> GetListUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<UserVM> users = db.Users.Select(
                u => new UserVM { 
                Id = u.Id,
                UserName = u.UserName,
                Image = u.Image
                }
                ).ToList();
                return users;
        }

        //GET THIS LAST FUNCTION WORKING: DISPLAY FOLLOWER LIST & DISPLAY CHIRPS OF FOLLOWER
        public List<FollowerVM> GetFollowers(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<FollowerVM> followers = db.Followers.Where(f => f.UserId == id).Select(
                f => new FollowerVM
                {
                    Id = f.Id,
                    UserId = f.User.Id,
                    FollowerName = f.Follower.Name
                }).ToList();
            return followers;
        }
    }
}
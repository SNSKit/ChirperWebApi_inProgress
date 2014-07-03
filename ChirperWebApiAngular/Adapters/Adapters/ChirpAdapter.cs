using Chirper.Data;
using Chirper.Data.Models;
using ChirperWebApiAngular.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChirperWebApiAngular.Adapters.Adapters
{
    public class ChirpAdapter : IChirp
    {
        public List<UserChirpVM> GetChirp()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<UserChirpVM> chirps = db.UserChirps.Select(
                c => new UserChirpVM { 
                Author = c.User.UserName,
                Message = c.Chirp.Message,
                SentAt = c.Chirp.Time
                }).ToList();
            return chirps;
        }


        public void AddChirp(UserChirpVM newChirp)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            User user = db.Users.Where(u => u.UserName == newChirp.Author).FirstOrDefault();
            Chirp chirp = new Chirp();
            chirp.Time = DateTime.Now;
            chirp.Message = newChirp.Message;
             
            db.Chirps.Add(chirp);
            db.SaveChanges();
            db.UserChirps.Add(new UserChirp
            {
                UserId = user.Id,
                ChirpId = chirp.Id,
            });
            db.SaveChanges();
        }
    }
}
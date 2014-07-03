using Chirper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChirperWebApiAngular.Adapters.Interfaces
{
    public interface IChirp
    {
        List<UserChirpVM> GetChirp();
        void AddChirp(UserChirpVM newChirp);
    }
}

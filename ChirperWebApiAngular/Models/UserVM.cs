using Chirper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChirperWebApiAngular.Models
{
    public class UserVM
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public List<UserChirp> Chirps { get; set; }
    }
}
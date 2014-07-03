using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChirperWebApiAngular.Models
{
    public class FollowerVM
    {
        public int Id { get; set; }
        public string FollowerName { get; set; }
        public int UserId { get; set; }
    }
}
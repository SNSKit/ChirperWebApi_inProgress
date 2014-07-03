using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Data.Models
{
    public class UserFollower
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int FollowerId { get; set; }
        public virtual User Follower { get; set; }
    }
}

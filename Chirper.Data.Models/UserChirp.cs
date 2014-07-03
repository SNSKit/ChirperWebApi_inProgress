using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Data.Models
{
    public class UserChirp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChirpId { get; set; }
        public virtual User User { get; set; }
        public virtual Chirp Chirp { get; set; }
    }
}

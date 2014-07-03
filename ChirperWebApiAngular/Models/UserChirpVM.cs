using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Data.Models
{
    public class UserChirpVM
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}

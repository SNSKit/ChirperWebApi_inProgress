namespace Chirper.Data.Migrations
{
    using Chirper.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chirper.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chirper.Data.ApplicationDbContext context)
        {
            User User1 = new User { Name = "Jacqueline", Email = "jac@me.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYTvAxhzlGEfs2-OZdBqIUcKFS1XQ4z-adRwgCqtyWwDAr7VaAJw", UserName = "Jacquelion" };
            User User2 = new User { Name = "Armando", Email = "armando@me.com", Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRE0TwhcRBrnuwEwI6CID2yL99bx_xwH1yMzggkS0UfPZzTM4bT", UserName = "HumongoElephant" };
            User User3 = new User { Name = "Loraine", Email = "loraine@me.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSP6STQ6dK4ZREwDC9SWw_UHvYHXP3W7HNByqpW22jctn4hUHj", UserName = "FreezingPenguin" };
            User User4 = new User { Name = "Annie", Email = "annie@me.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-22LkWENRq4P0LdDhaZEjOe4TzQy8rU6ZPGOH8xy1WibrBWkPRg", UserName = "RainbowBird" };
            User User5 = new User { Name = "Josh", Email = "josh@me.com", Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTEAvjj7w_gQUAgqT8RcJ_pikpwtMbVGbeQxXDHvMf9vYQmE977jg", UserName = "Joshaffe" };
            User User6 = new User { Name = "Jason", Email = "jason@me.com", Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTEAvjj7w_gQUAgqT8RcJ_pikpwtMbVGbeQxXDHvMf9vYQmE977jg", UserName = "CowMan" };
            context.Users.AddOrUpdate(
                u => u.UserName,
                User1,
                User2,
                User3,
                User4,
                User5,
                User6);
            context.SaveChanges();
            Chirp Chirp1 = new Chirp { Message = "Hello", Time = (DateTime.Now) };
            Chirp Chirp2 = new Chirp { Message = "Hey", Time = (DateTime.Now) };
            Chirp Chirp3 = new Chirp { Message = "Howdy", Time = (DateTime.Now) };
            Chirp Chirp4 = new Chirp { Message = "Sup", Time = (DateTime.Now) };
            Chirp Chirp5 = new Chirp { Message = "Hi", Time = (DateTime.Now) };
            Chirp Chirp6 = new Chirp { Message = "Heyo", Time = (DateTime.Now) };
            Chirp Chirp7 = new Chirp { Message = "How's it going?", Time = (DateTime.Now) };
            Chirp Chirp8 = new Chirp { Message = "Good, you?", Time = (DateTime.Now) };
            Chirp Chirp9 = new Chirp { Message = "Sup?", Time = (DateTime.Now) };
            Chirp Chirp10 = new Chirp { Message = "What's up?", Time = (DateTime.Now) };
            Chirp Chirp11 = new Chirp { Message = "How's your day?", Time = (DateTime.Now) };
            Chirp Chirp12 = new Chirp { Message = "Hey there.", Time = (DateTime.Now) };
            Chirp Chirp13 = new Chirp { Message = "Hey buddy.", Time = (DateTime.Now) };
            Chirp Chirp14 = new Chirp { Message = "Not bad.", Time = (DateTime.Now) };
            Chirp Chirp15 = new Chirp { Message = "Hanging in there.", Time = (DateTime.Now) };
            Chirp Chirp16 = new Chirp { Message = "Excellent.", Time = (DateTime.Now) };
            Chirp Chirp17 = new Chirp { Message = "Alright.", Time = (DateTime.Now) };
            Chirp Chirp18 = new Chirp { Message = "Awesome.", Time = (DateTime.Now) };
            context.Chirps.AddOrUpdate(
                c => c.Message,
                Chirp1,
                Chirp2,
                Chirp3,
                Chirp4,
                Chirp5,
                Chirp6,
                Chirp7,
                Chirp8,
                Chirp9,
                Chirp10,
                Chirp11,
                Chirp12,
                Chirp13,
                Chirp14,
                Chirp15,
                Chirp16,
                Chirp17,
                Chirp18
                );
            context.SaveChanges();
            context.UserChirps.AddOrUpdate(
                u => u.Id,
                new Chirper.Data.Models.UserChirp {Id = 1, UserId = User1.Id, ChirpId = Chirp1.Id},
                new Chirper.Data.Models.UserChirp {Id = 2, UserId = User2.Id, ChirpId = Chirp2.Id},
                new Chirper.Data.Models.UserChirp {Id = 3, UserId = User3.Id, ChirpId = Chirp3.Id},
                new Chirper.Data.Models.UserChirp {Id = 4, UserId = User4.Id, ChirpId = Chirp4.Id},
                new Chirper.Data.Models.UserChirp {Id = 5, UserId = User5.Id, ChirpId = Chirp5.Id},
                new Chirper.Data.Models.UserChirp {Id = 6, UserId = User6.Id, ChirpId = Chirp6.Id},
                new Chirper.Data.Models.UserChirp {Id = 7, UserId = User1.Id, ChirpId = Chirp7.Id},
                new Chirper.Data.Models.UserChirp {Id = 8, UserId = User2.Id, ChirpId = Chirp8.Id},
                new Chirper.Data.Models.UserChirp {Id = 9, UserId = User3.Id, ChirpId = Chirp9.Id},
                new Chirper.Data.Models.UserChirp {Id = 10, UserId = User4.Id, ChirpId = Chirp10.Id},
                new Chirper.Data.Models.UserChirp {Id = 11, UserId = User5.Id, ChirpId = Chirp11.Id},
                new Chirper.Data.Models.UserChirp {Id = 12, UserId = User6.Id, ChirpId = Chirp12.Id},
                new Chirper.Data.Models.UserChirp {Id = 13, UserId = User1.Id, ChirpId = Chirp13.Id},
                new Chirper.Data.Models.UserChirp {Id = 14, UserId = User2.Id, ChirpId = Chirp14.Id},
                new Chirper.Data.Models.UserChirp {Id = 15, UserId = User3.Id, ChirpId = Chirp15.Id},
                new Chirper.Data.Models.UserChirp {Id = 16, UserId = User4.Id, ChirpId = Chirp16.Id},
                new Chirper.Data.Models.UserChirp {Id = 17, UserId = User5.Id, ChirpId = Chirp17.Id},
                new Chirper.Data.Models.UserChirp {Id = 18, UserId = User6.Id, ChirpId = Chirp18.Id}
            );
            context.Followers.AddOrUpdate(
                f => f.Id,
                new UserFollower { Id=1, UserId = User1.Id, FollowerId = User2.Id},
                new UserFollower { Id=2, UserId = User1.Id, FollowerId = User4.Id},
                new UserFollower { Id=3, UserId = User1.Id, FollowerId = User6.Id},
                new UserFollower { Id=4, UserId = User2.Id, FollowerId = User1.Id},
                new UserFollower { Id=5, UserId = User2.Id, FollowerId = User3.Id},
                new UserFollower { Id=6, UserId = User2.Id, FollowerId = User5.Id}
                );
        }
    }
}

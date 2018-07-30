using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LegendaryOnline.Data.SeedData
{
    public static class HeroInitializerExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedCaptainAmerica(modelBuilder);
        }

        private static void SeedCaptainAmerica(ModelBuilder modelBuilder)
        {
            var captainAmeria = new Heroes.Hero { ID = 1, Name = "Captain America" };
            var cards = new List<Heroes.HeroCard> {
                new Heroes.HeroCard { ID=1, HeroID=1, Name = "Avengers Assemble!", Team=Heroes.HeroTeam.Avengers, Class=Heroes.HeroClass.Instinct,
                    BaseAttack =0,BaseRecruit=0, Cost=3, ImagePath="core/captain/aa.jpg" },
                new Heroes.HeroCard { ID=2, HeroID=1, Name = "Perfect Teamwork", Team=Heroes.HeroTeam.Avengers, Class=Heroes.HeroClass.Strength,
                    BaseAttack =0,BaseRecruit=0, Cost=4, ImagePath="core/captain/pt.jpg" },
                new Heroes.HeroCard { ID=3, HeroID=1, Name = "Diving Block", Team=Heroes.HeroTeam.Avengers, Class=Heroes.HeroClass.Tech,
                    BaseAttack =4,BaseRecruit=0, Cost=6, ImagePath="core/captain/db.jpg" },
                new Heroes.HeroCard { ID=4, HeroID=1, Name = "A Day Unlike Any Other", Team=Heroes.HeroTeam.Avengers, Class=Heroes.HeroClass.Covert,
                    BaseAttack =3,BaseRecruit=0, Cost=7, ImagePath="core/captain/aduao.jpg" }
            };

            modelBuilder.Entity<Heroes.Hero>().HasData(captainAmeria);
            modelBuilder.Entity<Heroes.HeroCard>().HasData(cards.ToArray());

            //context.Heroes.Add(hero);
            //context.HeroCards.Add(new Heroes.HeroCard
            //{
            //    Name = "A Day Unlike Any Other",
            //    Class = Heroes.HeroClass.Covert,
            //    Team = Heroes.HeroTeam.Avengers,
            //    Cost = 7,
            //    BaseRecruit = 0,
            //    BaseAttack = 3,
            //    Hero = hero,
            //    ImagePath = "core/captain/aduao.jpg"
            //});
        }
    }
}

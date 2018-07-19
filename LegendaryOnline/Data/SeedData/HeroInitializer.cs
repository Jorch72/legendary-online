using LegendaryOnline.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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
            modelBuilder.Entity<Heroes.Hero>().HasData(
                new Heroes.Hero { ID = 1, Name = "Captain America" }
            );

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

namespace WhereTo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WhereTo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WhereTo.Models.PlaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WhereTo.Models.PlaceContext context)
        {
            context.Places.AddOrUpdate(i => i.PlaceID,
                new Place
                {
            ApplicationUserID = "Jane Smith",
            PlaceID = "The Great Wall",
            IsCompleted = true,
            PlaceComment = "nice",
            Category = "Places Nearby",
                },

                 new Place
                {
            ApplicationUserID = "John Smith",
            PlaceID = "The Eiffel Tower",
            IsCompleted = true,
            PlaceComment = "awful",
            Category = "Places in France",
                }
             );
        }
    }
}
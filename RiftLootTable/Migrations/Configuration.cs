namespace RiftLootTable.Migrations
{
    using RiftLootTable.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RiftLootTableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RiftLootTableContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.GameVersions.AddOrUpdate(
              p => p.GameVersionId,
              new GameVersion { Name = "Rift: Planes of Telara", GameImagePath = "~/Content/Rift.png" },
              new GameVersion { Name = "Rift: Storm Legion", GameImagePath = "~/Content/stormlegion.png" },
              new GameVersion { Name = "Rift: Nightmare Tide", GameImagePath = "~/Content/nightmareTide.png" }
            );
            
        }
    }
}

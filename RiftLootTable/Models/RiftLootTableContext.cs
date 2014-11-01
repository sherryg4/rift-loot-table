using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RiftLootTable.Models
{
    public class RiftLootTableContext : DbContext
    {
        public IDbSet<GameVersion> GameVersions { get; set; }
    }
}
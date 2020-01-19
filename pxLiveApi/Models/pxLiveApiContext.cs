using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pxLiveApi.Models
{
    public class pxLiveApiContext : DbContext
    {
    
        public pxLiveApiContext() : base("name=pxLiveApiContext")
        {
        }

        public System.Data.Entity.DbSet<pxLiveApi.Models.Users> Users { get; set; }

        public System.Data.Entity.DbSet<pxLiveApi.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<pxLiveApi.Models.CurrentTrack> CurrentTracks { get; set; }

        public System.Data.Entity.DbSet<pxLiveApi.Models.Session> Sessions { get; set; }
    }
}

using projektzaginione.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projektzaginione.DAL
{
    public class dataContext : DbContext
    {
        public DbSet<LosePeople> LosePeople { get; set; }
    }
}
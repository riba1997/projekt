using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;


#nullable disable

namespace projekt.Models
{
    public partial class bazaContext : DbContext
    {

        public bazaContext(DbContextOptions<bazaContext> options)
            : base(options)
        {
        }

        public  DbSet<Film> Films { get; set; }
        public  DbSet<Kategoria> Kategoria { get; set; }
        public  DbSet<Rezyser> Rezysers { get; set; }
    }
}

using Clinica.Modelo_de_datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Clinica
{
    public class CitasContext : DbContext
    {
        public DbSet<Cita> Citas { get; set; }

        public CitasContext() : base("name=FisioterapiayOsteopatiaArielMongeEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>().ToTable("Citas");
        }
    }
}

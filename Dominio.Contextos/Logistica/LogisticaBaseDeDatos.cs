using Dominio.Entidades.Logistica;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contextos.Logistica
{
    public class LogisticaBaseDeDatos:DbContext
    {
        private static readonly string NOMBRE_CADENA_CONEXION = "LogisticaDB";

        public LogisticaBaseDeDatos() : base(NOMBRE_CADENA_CONEXION) {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Objeto> Objetos { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
    }
}

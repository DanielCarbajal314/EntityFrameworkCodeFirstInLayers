using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Logistica
{
    public class Objeto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual Paquete Paquete { get; set; }
    }
}

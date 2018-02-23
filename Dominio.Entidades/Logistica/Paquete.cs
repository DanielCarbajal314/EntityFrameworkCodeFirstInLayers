using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Logistica
{
    public class Paquete
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Destino { get; set; }
        public ICollection<Objeto> Objetos { get; set; }
    }
}

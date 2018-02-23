using System;
using System.Linq;
using Dominio.Contextos.Logistica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dominio.Pruebas
{
    [TestClass]
    public class BaseDeDatos
    {
        [TestMethod]
        public void DebeCrearce()
        {
            LogisticaBaseDeDatos db = new LogisticaBaseDeDatos();
            db.Paquetes.ToList();
        }
    }
}

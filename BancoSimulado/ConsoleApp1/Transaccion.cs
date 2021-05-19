using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimulado
{
    class Transaccion
    {
        public decimal Monto { get; }
        public DateTime Fecha { get; }
        public string Descripccion { get; }

        public Transaccion(decimal monto, DateTime fecha, string descripccion)
        {
            Monto = monto;
            Fecha = fecha;
            Descripccion = descripccion;
        }
    }
}

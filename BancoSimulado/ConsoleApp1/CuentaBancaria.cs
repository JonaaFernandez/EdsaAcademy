using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimulado
{
    class CuentaBancaria
    {
        public String NumeroDeCuenta { get; }
        public String NombreCliente { get; set; }
        public String ApellidoCliente { get; set; }
        public Decimal Balance
        {
            get
            {
                decimal Balance = 0;
                foreach (var item in TodasLasTransacciones)
                {
                    Balance += item.Monto;
                }

                return Balance;

            }
        }


        private static int accountNumberSeed = 1234567890;

        private List<Transaccion> TodasLasTransacciones = new List<Transaccion>();

        //CONSTRUCTOR
        public CuentaBancaria(string apellido, string nombre, decimal balanceInicial)
        {
            ApellidoCliente = apellido;
            NombreCliente = nombre;
            //Balance = balanceInicial;
            NumeroDeCuenta = accountNumberSeed.ToString();
            accountNumberSeed++;
            RealizarDeposito(balanceInicial, DateTime.Now, "Balance Inicial");
        }


        //METODOS
        public void RealizarDeposito(decimal monto, DateTime fecha, string descripcion)
        {
            if (monto <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto del deposito debe ser POSITIVO");
            }
            var depoito = new Transaccion(monto, fecha, descripcion);
            TodasLasTransacciones.Add(depoito);
        }

        public void RealizarRetiro(decimal monto, DateTime fecha, string descripcion)
        {
            if (monto <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto a retirar debe ser POSITIVO");
            }
            if (Balance - monto < 0)
            {
                throw new InvalidOperationException("Fondos INSUFICIENTES para realizar este retiro");
            }
            var retiro = new Transaccion(-monto, fecha, descripcion);
            TodasLasTransacciones.Add(retiro);
        }

        public string HistorialDeCuenta(){
            // CREAMOS UNA TABLA CON EL HISTORIAL DE TRANSACCIONES DEL CLIENTE
            var reporte = new StringBuilder();
        
            //HEADER DE LA TABLA
            reporte.AppendLine("\tFECHA\t\tMONTO\t\tDESCRIPCION");
            foreach (var transaccion in TodasLasTransacciones){
                //FILAS DE LA TABLA
                reporte.AppendLine($"\n \t{transaccion.Fecha.ToShortDateString()}\t{"$" + transaccion.Monto}\t\t{transaccion.Descripccion}");
            }
            return reporte.ToString();
       
        }
    }
}

using System;

namespace BancoSimulado
{
    class Program
    {
        static void Main(string[] args)
        {
            var CuentaNueva = new CuentaBancaria("Fernandez", "Jonatan", 20000);
            Console.WriteLine($"\tLa cuenta Nro: {CuentaNueva.NumeroDeCuenta} fue creada por el Sr/Sra: {CuentaNueva.ApellidoCliente} {CuentaNueva.NombreCliente} \n\tMonto Inicial:  ${ CuentaNueva.Balance}.");


            CuentaNueva.RealizarRetiro(5100, DateTime.Now, "3 Kg Asado, 1 Rosca chorizo, 2 Kg Pan");
            //Console.WriteLine(CuentaNueva.Balance);
        
            CuentaNueva.RealizarDeposito(10000,DateTime.Now, "Aguinaldo");
            //Console.WriteLine(CuentaNueva.Balance);

            CuentaNueva.RealizarRetiro(12000, DateTime.Now, "Silla Gamer Secret Lab");
           // Console.WriteLine(CuentaNueva.Balance);
           
            Console.WriteLine("\n" + CuentaNueva.HistorialDeCuenta());
            Console.WriteLine("\n\t\t\t MUCHAS GRACIAS POR SER PARTE DE BANCO SIMULADO COMPANY.");
            Console.WriteLine("\n\n");

            // TEST para que el balance INICIAL sea POSITIVO.


            //try
            //{
            //   var cuentaInvalida = new CuentaBancaria("Ciruja","Pepe", -5500);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Excepción, imposible crear una cuenta con saldo negativo");
            //   // Console.WriteLine(e.ToString());   ---- >  event
            //    return;
            //}


            // TEST para balance NEGATIVO.
            //try
            //{
            //    CuentaNueva.RealizarRetiro(50000, DateTime.Now, "Sacar mas de lo que puedo!!!");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Excepción, supera el total de sus fondos!");
            //    //Console.WriteLine(e.ToString());
            //}

        }
    }
}

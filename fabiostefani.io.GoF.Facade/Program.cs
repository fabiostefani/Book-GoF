using fabiostefani.io.GoF.Facade.Entidades;
using System;

namespace fabiostefani.io.GoF.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var atm = new ATMFacade("123456");
            atm.Depositar(100);

            atm.Sacar(10);

            atm.ObterSaldo();

            Console.ReadKey();
        }
    }
}

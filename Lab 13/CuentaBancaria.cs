using System;
using System.Collections.Generic;
using System.Text;

namespace LAB13_RICARDOGONZALEZ
{
    internal class CuentaBancaria
    {
        //Atributos
        private string titular = "";
        private double saldo = 0;
        //Metodos
        //Constructor
        public CuentaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }
        public void depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine(titular + "Deposito Q" + cantidad.ToString());
            Console.WriteLine("Nuevo Saldo: " + saldo.ToString());
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("Cliente: " + titular);
            Console.WriteLine("Saldo Actual: " + saldo.ToString());
        }
        public void retirar(double retirars)
        {
            saldo -= retirars;
            Console.WriteLine(titular + "Retiro Q" + retirars.ToString());
            Console.WriteLine("Nuevo Saldo: " + saldo.ToString());
        }
    }
}
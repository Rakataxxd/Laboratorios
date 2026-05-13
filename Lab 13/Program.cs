namespace LAB13_RICARDOGONZALEZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lab 13 Ejercicio 1");
            Console.WriteLine("Jecho por Ricardo Gonzalez");
            Console.WriteLine("------------------------------------------");

            //Instanciar un objeto
            CuentaBancaria cuentaBancaria = new CuentaBancaria("Fatima", 1500);
            cuentaBancaria.mostrarInformacion();
            cuentaBancaria.depositar(500);
            cuentaBancaria.mostrarInformacion();
            cuentaBancaria.retirar(250);
            cuentaBancaria.mostrarInformacion();
        }
    }
}

namespace LAB13_2_RICARDOGONZALEZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Lab 13 Ejercicio 2");
            Console.WriteLine("Jecho por Ricardo Gonzalez 1121726");
            Console.WriteLine("-------------------------------------------------------");


            Termostato termostato = new Termostato(" Guatemala ", 100 );
            termostato.mostrarInformacion();

        }
    }
}


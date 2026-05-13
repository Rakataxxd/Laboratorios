namespace Lab10_Ricardo_Gonzalez_04_08
{
    internal class Program
    {
        /// <summary>
        /// Calcula area circulo
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns>
        static double calcularAreaCirculo(double radio)
        {
            double resultado = 3.1416 * Math.Pow(radio, 2);
            return resultado;
        }
        static double calcularAreaCuadrado(double lado)
        {
            double resultado =  Math.Pow(lado, 2);
            return resultado;
        }
        static double calcularAreaRectangulo(double baseRectangulo,double alturaRectangulo)
        {
            double resultado = baseRectangulo * alturaRectangulo;
            return resultado;
        }
        static double calcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double resultado = baseTriangulo * alturaTriangulo;
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("LAB 10 EJECICIO 1: FIGURAS GEOMETRICAS");
            Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
            Console.WriteLine("------------------------------------------");
            int opcion = 0;
            do
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Area de circuito \n2 2. Area de cuadrado \n3 3. Area del rectangulo \n4 4. Area del triangulo \n5 5.Salida");
                opcion = Convert.ToInt32(Console.ReadLine());
            
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el radio");
                            double radio = Convert.ToInt32(Console.ReadLine());
                            double areaCirculo = calcularAreaCirculo(radio);
                            Console.WriteLine("El area del circulo es: " + areaCirculo.ToString());

                        break;

                        case 2:
                            Console.WriteLine("Ingrese el lado");
                            double lado= Convert.ToInt32(Console.ReadLine());
                            double areaCuadrado = calcularAreaCuadrado(lado);
                            Console.WriteLine("El area del circulo es " + areaCuadrado.ToString());
                        break;

                        case 3:
                            Console.WriteLine("Ingrese base del rectangulo");
                            double baseRectangulo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese altura del rectangulo");
                            double alturaRectangulo = Convert.ToInt32(Console.ReadLine());
                            double areaRectangulo = calcularAreaRectangulo(alturaRectangulo,baseRectangulo);
                            Console.WriteLine("El area del rectangulo es " + areaRectangulo);
                        break;

                        case 4:
                            Console.WriteLine("Ingrese base del Triangulo");
                            double baseTriangulo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese altura del Triangulo");
                            double alturaTriangulo = Convert.ToInt32(Console.ReadLine());
                            double areaTriangulo = calcularAreaRectangulo(alturaTriangulo, baseTriangulo);
                            Console.WriteLine("El area del rectangulo es " + areaTriangulo/2);


                        break;
                }
            } while (opcion != 5);
            Console.WriteLine("Nos vemos!");
        }      
}
}

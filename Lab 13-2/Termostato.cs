using System;
using System.Collections.Generic;
using System.Text;

namespace LAB13_2_RICARDOGONZALEZ
{
    internal class Termostato
    {
        //Atributos
        private string ubicacion = "";
        private double temperatura = 0;
        public Termostato(string ubicacion, double temperatura)
        {
            this.ubicacion = ubicacion;
            this.temperatura = temperatura;
        }
        public void termostatot(string ubicacion, double temperatura)
        {
            Console.WriteLine("Ingresar Ubicacion" + ubicacion.ToString());
            Console.WriteLine("Temperatura" + temperatura.ToString());
        }
        public void ajustarTemperatura(double nuevaTemp)
        {
            temperatura=nuevaTemp;
            Console.WriteLine("Ingresar nueva temperatura" + nuevaTemp.ToString());
            Console.WriteLine("Temperatura" + temperatura.ToString());
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("La ubicacion es :" + ubicacion);
            Console.WriteLine("La temperatura en grados centigrados es : " + temperatura);
        }


    }
}

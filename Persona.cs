using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4._4
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Edad = 0;
            Edad = 0;
            Peso = 0;
            Altura = 0;
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            Nombre= nombre;
            Edad= edad;
            Sexo= sexo;
            Peso= peso;
            Altura= altura;
        }

        public int CalcularIMC()
        {
            double imc = Peso / (Altura * Altura);
            if (imc < 20)
            {
                return -1;
            }
            else if (imc > 25)
            {
                return 1;
            }
            else return 0;
        }

        public bool EsMayorDeEdad()
        {
            if(Edad >= 21)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre} | Edad: {Edad} |Sexo: {Sexo} |Peso: {Peso} |Altura: {Altura} |IMC: {CalcularIMC()} |¿Es Mayor de Edad?: {EsMayorDeEdad()}";
        }
    }
}

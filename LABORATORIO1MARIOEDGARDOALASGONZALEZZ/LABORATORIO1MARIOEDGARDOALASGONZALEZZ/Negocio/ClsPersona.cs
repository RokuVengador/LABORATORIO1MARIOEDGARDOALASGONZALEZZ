using LABORATORIO1MARIOEDGARDOALASGONZALEZZ.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1MARIOEDGARDOALASGONZALEZZ.Negocio
{
    public class ClsPersona
    {
        public string CalcularIMC(Persona r)
        {
            double calculo = r.Peso / Math.Pow(r.Altura, 2);
            if (calculo < 24)
            {
                return ("Pesas: " + r.Peso + " kg, Tienes un peso ideal, deves estar feliz :) ...");

            }
            else
            {
                return ("Pesas: " + r.Peso + " kg, Tienes sobrepeso, necesita ir a correr :( ...");

            }

        }

        
        
       
        public string Esmayordeedad(Persona r)
        {
            if (r.Edad >= 18)
            {
                return ("Tienes: " + r.Edad + " años, " + " " + "Eres mayor de edad, se amable.");
            }
            else
            {
                return ( "Tienes: " + r.Edad + " años, "  + " " + "Eres menor de edad, se obediente.");
            }

        }
       
    }
}
//Console.WriteLine("y");
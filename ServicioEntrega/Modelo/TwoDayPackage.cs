using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioEntrega.Modelo
{
    public class TwoDayPackage :Package
    {
        int cuotafija;

        public int Cuotafija
        {
            get { return cuotafija; }
            set { cuotafija = value; }
        }
        public TwoDayPackage() : base()
        {
            cuotafija = 0;
           
        }
        public TwoDayPackage(string nombre, string codigo, string direccion, string ciudad, string departamento, string codigopostalr, string codigopostald, int peso, int costo, int cuotafija)
            :base(   codigo, nombre,  direccion,  ciudad,  departamento,  codigopostalr,  codigopostald,  peso,  costo) 

        {
            this.cuotafija = cuotafija;
            
        }
        public override string ToString()
        {
            return base.ToString() +
                    "cuota fija: " + this.cuotafija +
                    '\n';

        }
        public override int calculateCost(int calculate)
        {
            calculate = Peso * cuotafija;
            return calculate;

           
        }



    }
}
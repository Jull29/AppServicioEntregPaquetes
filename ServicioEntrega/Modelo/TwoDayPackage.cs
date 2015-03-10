using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioEntrega.Modelo
{
    public class TwoDayPackage :Package
    {
        int cuotafija;
        string dias;

        public string Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        string efectividadanual;

        public string Efectividadanual
        {
            get { return efectividadanual; }
            set { efectividadanual = value; }
        }
        public int Cuotafija
        {
            get { return cuotafija; }
            set { cuotafija = value; }
        }
        public TwoDayPackage() : base()
        {
            cuotafija = 0;
           
        }
        public TwoDayPackage(string nombre, string codigo, string direccion, string ciudad, string departamento, string codigopostalr, string codigopostald, int peso, int costo, int cuotafija, string dias, string efectividadanual)
            :base(   codigo, nombre,  direccion,  ciudad,  departamento,  codigopostalr,  codigopostald,  peso,  costo) 

        {
            this.cuotafija = cuotafija;
            
        }
        public override string ToString()
        {
            return base.ToString() +
                    "cuota fija: " + this.cuotafija +
                     "dias: " + this.dias +
                      "Efectividad anual " + this.Efectividadanual +
                    '\n';

        }
        public override int calculateCost(int calculate)
        {
            calculate = Peso * cuotafija;
            return calculate;

           
        }



    }
}
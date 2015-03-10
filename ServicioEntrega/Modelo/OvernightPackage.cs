using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioEntrega.Modelo
{
    public class OvernightPackage:Package
    {
        int costonocturno;

        public int Cuotafija
        {
            get { return costonocturno; }
            set { costonocturno = value; }
        }
        public OvernightPackage() : base()
        {
            costonocturno = 0;
           
        }
        public OvernightPackage(string nombre, string codigo, string direccion, string ciudad, string departamento, string codigopostalr, string codigopostald, int peso, int costo, int costonocturno)
            :base(   codigo, nombre,  direccion,  ciudad,  departamento,  codigopostalr,  codigopostald,  peso,  costo) 

        {
            this.costonocturno = costonocturno;
            
        }
        public override string ToString()
        {
            return base.ToString() +
                    "costo nocturno: " + this.costonocturno +
                    '\n';

        }
        public override int calculateCost(int calculate)
        {
            calculate = Peso * costonocturno;
            return calculate;

           
        }


    
}
}

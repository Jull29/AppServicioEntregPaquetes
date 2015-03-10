using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioEntrega.Modelo
{
    public abstract class Package
    {
        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        string codigopostalr;

        public string Codigopostalr
        {
            get { return codigopostalr; }
            set { codigopostalr = value; }
        }
        string codigopostald;

        public string Codigopostald
        {
            get { return codigopostald; }
            set { codigopostald = value; }
        }
        int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        public Package(string nombre, string codigo, string direccion, string ciudad, string departamento, string codigopostalr, string codigopostald, int peso, int costo) 
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.departamento = departamento;
            this.codigopostalr = codigopostalr;
            this.codigopostald = codigopostald;
            this.direccion = direccion;
            this.peso = peso;
            this.costo = costo;


        
        }

        public Package()
        {

        }
        public override string ToString()
        {
            return "nombre: " + this.nombre +
                    "\ncodigo: " + this.codigo +
                    "\ndireccion: " + this.direccion +
                    "\nciudad: " + this.ciudad +
                    "\ndepartamento: " + this.departamento +
                    "\ncodigopostalr: " + this.codigopostalr +
                    "\ncodigopostald: " + this.codigopostald +
                    "\npeso: " + this.peso +
                    "\ncosto: " + this.costo +
                    '\n';
        }



        public override int calculateCost(int calculate)
        {

             calculate = peso * costo;
             return calculate;
        
        
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    abstract class Persona
    {
        //private int id;
        private string nombre;
        private char sexo; //F:femenino M:masculino
        private DateTime fechaNac;
        private string direccion;
        private string telefono;
        private string mail;

        public abstract int Id
        {
            set;
            get;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public DateTime FechaNac
        {
            set { fechaNac = value; }
            get { return fechaNac; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public string SexoToString()
        {
            if (Sexo == 'M')
                return "Masculino";
            else
                return "Femenino";
        }
    }
}
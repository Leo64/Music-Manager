using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    class Autor : Persona//prueba
    {
        private int idAutor;

        public override int Id
        {
            set { idAutor = value; }
            get { return idAutor; }
        }
    }
}

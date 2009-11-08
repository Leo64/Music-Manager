using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    class Disqueria
    {
        private int idDisqueria;
        private string descripcion;

        public int IdDisqueria
        {
            set { idDisqueria = value; }
            get { return idDisqueria; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
    }
}

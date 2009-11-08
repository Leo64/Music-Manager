using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Manager
{
    class Album
    {
        int idAlbum;
        int idGenero;
        int idDisqueria;
        int idCompania;
        int idgrupo;
        bool varios_Artitas;
        decimal costo;
        string fecha_Terminado;
        string fecha_Lanzamiento;
        int cantidad_Temas;
        int duracion_Album;
        string obsevaciones;
        //metodos
        public int IdAlbum
        {
            set { idAlbum = value; }
            get { return idAlbum; }
        }

        public int IdGenero
        {
            set { idGenero = value; }
            get { return idGenero; }
        }

        public int IdDisqueria
        {
            set { idDisqueria = value; }
            get { return idDisqueria; }
        }

        public int IdCompania
        {
            set { idCompania = value; }
            get { return idCompania; }
        }

        public int IdGrupo
        {
            set { idgrupo = value; }
            get { return idgrupo; }
        }

        public bool Varios_Artitas
        {
            set { varios_Artitas = value; }
            get { return varios_Artitas; }
        }

        public decimal Costo
        {
            set { costo = value; }
            get { return costo; }
        }

        public string Fecha_Terminado
        {
            set { fecha_Terminado = value; }
            get { return fecha_Terminado; }
        }

        public string Fecha_Lanzamiento
        {
            set { fecha_Lanzamiento = value; }
            get { return fecha_Lanzamiento; }
        }

        public int Cantidad_Temas
        {
            set { cantidad_Temas = value; }
            get { return cantidad_Temas; }
        }

        public int Duracion_Album
        {
            set { duracion_Album = value; }
            get { return duracion_Album; }
        }

        public string Obsevaciones
        {
            set { obsevaciones = value; }
            get { return obsevaciones; }
        }

        public Album()
        {
            this.idAlbum = 0;
            this.idGenero = 0;
            this.IdDisqueria = 0;
            this.IdCompania = 0;
            this.IdGrupo = 0;
            this.Varios_Artitas = false;
            this.Costo = 0;
            this.Fecha_Terminado = null;
            this.fecha_Lanzamiento = null;
            this.Cantidad_Temas = 0;
            this.Duracion_Album = 0;
            this.Obsevaciones = null;
        }

        public Album(int IdAlbum, int IdGenero, int IdDisqueria, int IdCompania, int IdGrupo, bool Varios_Artistas, decimal Costo, string Fecha_Terminado, string Fecha_Lanzamiento, int Cantidad_Temas, int Duracion_Album, string Obsevaciones)
        {
            this.idAlbum = IdAlbum;
            this.idGenero = IdAlbum;
            this.IdDisqueria = IdDisqueria;
            this.IdCompania = IdDisqueria;
            this.IdGrupo = IdGrupo;
            this.Varios_Artitas = Varios_Artistas;
            this.Costo = Costo;
            this.Fecha_Terminado = Fecha_Terminado;
            this.fecha_Lanzamiento = Fecha_Lanzamiento;
            this.Cantidad_Temas = Cantidad_Temas;
            this.Duracion_Album = Duracion_Album;
            this.Obsevaciones = Obsevaciones;
        }
    }
}

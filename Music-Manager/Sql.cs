using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Music_Manager
{
    class Sql
    {
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataReader dataReader;
        private string stringConexion, consulta;

        public SqlConnection Conexion
        {
            set { conexion = value; }
            get { return conexion; }
        }

        public SqlCommand Command
        {
            set { command = value; }
            get { return command; }
        }

        public SqlDataReader DataReader
        {
            set { dataReader = value; }
            get { return dataReader; }
        }

        public string StringConexion
        {
            set { stringConexion = value; }
            get { return stringConexion; }
        }

        public string Consulta
        {
            set { consulta = value; }
            get { return consulta; }
        }

        public Sql()
        {
            Conexion = new SqlConnection();
            Command = new SqlCommand();
            DataReader = null;
            Consulta = null;
        }

        /* NAME: Conectar 
         * DESCRIPTION: conexion a una base de datos
         * PARAMETERS: int, string, servidor, usuario, contrasenia
         * RETURNS: true:conexion exitosa false:conexion fallida
         */
        public bool Conectar(int tipoAutenticacion, string db, string servidor, string usuario, string contrasenia)
        {
            switch (tipoAutenticacion)
            {
                case 0:
                    StringConexion = @"Data Source=.\" + servidor + ";"
                        + @"AttachDbFilename=C:\Archivos de programa\Microsoft SQL Server\MSSQL.1\MSSQL\Data\" + db + "_data" + ".mdf;"
                        + "Database=" + db + ";"
                        + "Trusted_Connection=Yes;MultipleActiveResultSets=True";
                    break;
                case 1:
                    StringConexion = @"Data Source=" + servidor + ";"
                        + "Initial Catalog=" + servidor + ";" 
                        + "User Id=" + usuario + ";"
                        + "Password=" + contrasenia + ";";
                    break;
            }

            try
            {
                Conexion.ConnectionString = StringConexion;
                Conexion.Open();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_SeleccionNombreConjunto_Solista
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: none
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_SeleccionNombreGrupo ()
        {
            Command.CommandText = "sp_SeleccionNombreGrupo";
            Command.CommandType = CommandType.StoredProcedure;

            try 
            {
                Command.Connection = Conexion;
                DataReader = Command.ExecuteReader();
            } 
            catch (SqlException) 
            {
                return false;
            }

            return true;
        }

        /* NAME: sp_SeleccionAlbumPorGrupo
         * DESCRIPTION: llama a un procedimiento almacenado
         * PARAMETERS: int
         * RETURNS: true:consulta exitosa false:consulta fallida
         */
        public bool sp_SeleccionAlbumPorGrupo (string nombreGrupo)
        {
            SqlParameter parametro = new SqlParameter("@nombreGrupo", SqlDbType.NVarChar);
            parametro.Value = nombreGrupo;

            Command.CommandText = "sp_SeleccionAlbumPorGrupo";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add(parametro);

            try
            {
                Command.Connection = Conexion;
                DataReader = Command.ExecuteReader();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }
    }
}

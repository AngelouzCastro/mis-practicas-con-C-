using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.BaseDatos
{
    class Conexion
    {
        OdbcConnection ConexionMySQL;

        public void conectar(String Controlador, String Servidor, String BaseDatos, String Usuario, String Password)
        {
            //Conexion al servidor de MySQL por medio del ConnectionString
            ConexionMySQL = new OdbcConnection("DRIVER={" + Controlador + "};SERVER=" + Servidor + ";DATABASE=" + BaseDatos + ";UID=" + Usuario + ";PWD=" + Password + ";");
            ConexionMySQL.Open();
        }
        public DataSet ejecutarConsulta(String SQL)
        {
            OdbcDataAdapter AdaptadorDatos = new OdbcDataAdapter(SQL, ConexionMySQL);
            DataSet resultado = new DataSet();
            AdaptadorDatos.Fill(resultado);
            return resultado;
        }
      
        public void ejecutarActualizacion(String SQL)
        {
            OdbcCommand Comando = new OdbcCommand(SQL, ConexionMySQL);
            Comando.ExecuteNonQuery();
        }
        public void desconectar()
        {
            ConexionMySQL.Close();
        }

    }
}

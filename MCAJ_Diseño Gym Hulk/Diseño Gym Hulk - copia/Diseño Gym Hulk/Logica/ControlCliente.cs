using Diseño_Gym_Hulk.BaseDatos;
using Diseño_Gym_Hulk.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Logica
{
    class ControlCliente
    {
        Conexion mConexion;
        public ControlCliente()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "mydb", "root", "DARKAR");
        }

        public void agregarCliente(Cliente mCliente)
        {
            String SQL = "insert into cliente values (null,'?1','?2','?3')";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Telefono.ToString());
            SQL = SQL.Replace("?3", mCliente.Apellido);
            mConexion.ejecutarActualizacion(SQL);
        }
        public DataSet consultarClientes()
        {
            String SQL = "select * from cliente";
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public  DataSet verCliente(int id,string fecha_actual)
        {
            String SQL = "select venta_membresia.Fecha_inicio, venta_membresia.Fecha_fin, membresia.Descripcion, cliente.Nombre, cliente.Apellidos from venta_membresia inner join membresia on venta_membresia.idVenta = membresia.idMembresia inner join cliente on  venta_membresia.Cliente_idCliente = cliente.idCliente where idCliente =" + id + " and Fecha_fin > '" + fecha_actual + "'";
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public DataSet consultarClientes2(string nombre)
        {
            String SQL = "select * from cliente where  Nombre = '"+nombre+"'";
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public DataSet consultarClientes3(string nombre)
        {
            String SQL = "SELECT * FROM cliente WHERE Nombre LIKE '%"+nombre+"%'";
            DataSet ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public void modificarCliente(Cliente mCliente)
        {
            String SQL = "update cliente set Nombre='?1',Telefono='?2',Apellidos='?3' where idCliente='?4'";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Telefono.ToString());
            SQL = SQL.Replace("?3", mCliente.Apellido);
            SQL = SQL.Replace("?4", mCliente.IDCliente.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
        public void eliminarCliente(int ID)
        {
            String SQL = "delete from cliente where idCliente='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
    }
}

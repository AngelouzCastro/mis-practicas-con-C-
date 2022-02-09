using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Gym_Hulk.Datos
{
    class Cliente
    {
        private int idCliente;
        private int telefono;
        private String nombre;
        private String apellido;


        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }
}

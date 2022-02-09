using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCAJ_PFinal
{
    class Archivo
    {
        private StreamWriter Escritor;

        public Archivo(string NombreArchivo)
        {
            Escritor =
                new StreamWriter(NombreArchivo, true);
        }

        public void CerrarArchivo()
        {
            Escritor.Close();
        }
        public void GuardarCoordenada0(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = mTienda.GetNombre();
            Escritor.WriteLine(linea + "\n");
        }

        public void GuardarCoordenada(Producto mProducto,Tienda mTienda)
        {
            string linea;
            linea = mProducto.GetClave() + "," +
                mProducto.GetNombre() + ", Cmpa: " +
                mProducto.GetPrecio() + ",Vta:  " + mProducto.GetPrecioV();
            Escritor.WriteLine(linea+"\n");
        }
        public void GuardarCoordenadaC(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = "Precio de Costo: $"+mTienda.GetPC();
            Escritor.WriteLine(linea);
        }
        public void GuardarCoordenada2(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = "Precio de Venta: $" + mTienda.GetPV();
            Escritor.WriteLine(linea);
        }
        public void GuardarCoordenada3(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea =  "Menor costo : " + mTienda.GetMayor();
            Escritor.WriteLine(linea);
        }
        public void GuardarCoordenada4(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = "Mayor Costo: " + mTienda.GetMenor();
            Escritor.WriteLine(linea);
        }
        public void GuardarCoordenada5(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = "Ganancia: $" + mTienda.GetGanancia();
            Escritor.WriteLine(linea);
        }
        public void GuardarCoordenadaCreador(Producto mProducto, Tienda mTienda)
        {
            string linea;
            linea = "Compañia: Angel  josue Martinez & Ivan Gtz ";
            Escritor.WriteLine(linea);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_PFinal
{
    class Interfaz
    {
        private string NombreT;
        private string Clave;
        private string NombreP;
        private double Precio;
        private double PrecioV;
        private int NumeroProductos;
        private int Opcion;

        public Interfaz()
        {
            NombreT = "";
            Clave = "";
            NombreP = "";
            Precio = 0;
            PrecioV = 0;
            NumeroProductos = 0;
            Opcion = 0;
        }
        
        public bool VerificarNombreP()
        {
            bool correcto = false;

            if (NombreP.Length > 0)
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }

            if (correcto)
            {
                for (int i = 0; i < NombreP.Length; i++)
                {
                    if (!Char.IsLetter(NombreP[i]))
                    {
                        correcto = false;
                        break;
                    }
                }
            }

            if (correcto)
            {
                if (!NombreP.Contains("%"))
                {
                    correcto = true;
                }
                else
                {
                    correcto = false;
                }
            }

            return correcto;
        }

        public void PedirNombreT()
        {
                Console.Write("Dame Nombre de la tienda: ");
                 NombreT = Console.ReadLine(); 
        }
        public void PedirNombreP()
        {  bool Corrercto = false;
            do
            {
                Console.Write("Dame Nombre del producto: ");
                try
                {
                    NombreP = Console.ReadLine();
                    Corrercto = VerificarNombreP();
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    Corrercto = false;
                }
            } while (!Corrercto);
            
            
            
        }
        public void PedirClave()
        {
            Console.Write("Dame clave de producto: ");
            Clave = Console.ReadLine();
        }
        public void PedirPrecio()
        {
            bool correcto = false;

            do
            {
                Console.Write("Dame Precio de compra: ");
                try
                {
                    Precio = double.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (correcto == false);
            
            
        }
        public void PedirPrecioV()
        {
            bool correcto = false;

            do
            {
                Console.Write("Dame Precio de Venta: ");
                try
                {
                    PrecioV = double.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (correcto == false);


        }
        public void PedirNumeroProductos()
        {
            bool correcto = false;

            do
            {
                Console.Write("Dame número de Productos: ");
                try
                {
                    NumeroProductos = int.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (correcto == false);
            
        }

        public void ImprimirOpcion(string texto, ConsoleColor color, ConsoleColor fondo, int posx, int posy)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = fondo;
            Console.SetCursorPosition(posx, posy);
            Console.WriteLine(texto);
        }

        public void ImprimirMenu(int sombreada)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            ImprimirOpcion(NombreT, ConsoleColor.Red, ConsoleColor.Black, 05, 1);


            switch (sombreada)
            {
                case 1:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Black, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);

                    break;
                case 2:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Black, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 3:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Black, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 4:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Black, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 5:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Black, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 6:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Black, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 7:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Black, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Blue, 05, 10);
                    break;
                case 8:
                    ImprimirOpcion("   Agreagar Producto              ", ConsoleColor.White, ConsoleColor.Blue, 05, 3);
                    ImprimirOpcion("   Costo de inventario (Compra)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 4);
                    ImprimirOpcion("   Precio de inventario (Venta)   ", ConsoleColor.White, ConsoleColor.Blue, 05, 5);
                    ImprimirOpcion("   Ganancia                       ", ConsoleColor.White, ConsoleColor.Blue, 05, 6);
                    ImprimirOpcion("   Producto mas caro              ", ConsoleColor.White, ConsoleColor.Blue, 05, 7);
                    ImprimirOpcion("   Producto mas barato            ", ConsoleColor.White, ConsoleColor.Blue, 05, 8);
                    ImprimirOpcion("   Imprimir reporte               ", ConsoleColor.White, ConsoleColor.Blue, 05, 9);
                    ImprimirOpcion("   Salir                          ", ConsoleColor.White, ConsoleColor.Black, 05, 10);
                    break;
            }
        }

        public void ImprimirMenu()
        {
            ImprimirMenu(1);
            Opcion = 1;
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        Opcion++;
                        if (Opcion > 8)
                        {
                            Opcion = 1;
                        }
                        ImprimirMenu(Opcion);
                        break;
                    case ConsoleKey.UpArrow:
                        Opcion--;
                        if (Opcion < 1)
                        {
                            Opcion = 8;
                        }
                        ImprimirMenu(Opcion);
                        break;
                }
            } while (tecla.Key != ConsoleKey.Enter);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public string GetNombreT()
        {
            return NombreT;
        }
        public string GetNombreP()
        {
            return NombreP;
        }
        public string GetClave()
        {
            return Clave;
        }
        public double GetPrecio()
        {
            return Precio;
        }
        public double GetPrecioV()
        {
            return PrecioV;
        }
        public int GetNumeroProductos()
        {
            return NumeroProductos;
        }

        public void ImprimirTiket(Tienda mTienda)
        {
            Producto mProducto;
            int i;

            
            Console.WriteLine(mTienda.GetNombre());
            Console.WriteLine("Clave    Producto    PrecioC     PrecioV");
            for(i=0; i<mTienda.GetNumeroProductos();i++)
            {
                mProducto = mTienda.GetProducto(i);
                Console.WriteLine(mProducto.GetClave()+"     "+mProducto.GetNombre()+"               $"+mProducto.GetPrecio()+ "          $"+ mProducto.GetPrecioV());
            }
            Console.WriteLine("Total Precio de compra:  $" + mTienda.GetPC());
            Console.WriteLine("Total  Precio de venta:  $" + mTienda.GetPV());
        }
        public void  ImprimirCI(Tienda mTienda)
        {
            Console.WriteLine("Costo de Inventario: " + mTienda.GetPC());
        }
        public void ImprimirCV(Tienda mTienda)
        {
            Console.WriteLine("Precio de Venta: "+ mTienda.GetPV());
        }
        public void ImprimirGanancia(Tienda mTienda)
        {
            double Ganancia;
            Ganancia = mTienda.GetPV() - mTienda.GetPC();
            Console.WriteLine("Ganancia: $" + Ganancia);
        }
        public void ImprimirMayor(Tienda mTienda,  Producto  mProducto)
        {
            Console.WriteLine("Clave    Producto    Precio");
            Console.WriteLine("Mas varato: "+mTienda.GetMayor());
        }
        public void ImprimirMenor(Tienda mTienda, Producto mProducto)
        {
            Console.WriteLine("Clave    Producto    Precio ");
            Console.WriteLine("Mas Caro: " + mTienda.GetMenor());
        }
        public void ImprimirError(string Texto)
        {
            Console.WriteLine("Error: " + Texto);
        }
    }
}

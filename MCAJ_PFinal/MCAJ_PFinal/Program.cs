using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MCAJ_PFinal
{
    class Program
    {
        private Interfaz mInterfaz;
        private Tienda mTienda;
        private Producto mProducto;
        private Archivo mArchivo;

        public Program()
        {
            mInterfaz = new Interfaz();
            mArchivo = new Archivo("Tienda.txt");
        }

        public void Correr()
        {
            int Opcion;
            string Otra = "";
            int i;

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch (Opcion)
                {
                    case 1:
                        
                            mInterfaz.PedirNombreT();
                            mInterfaz.PedirNumeroProductos();
                            mTienda = new Tienda(mInterfaz.GetNumeroProductos());
                            mTienda.SetNombre(mInterfaz.GetNombreT());


                            mArchivo.GuardarCoordenada0(mProducto, mTienda);
                            for (i = 0; i < mTienda.GetNumeroProductos(); i++)
                            {
                                mProducto = new Producto();
                                mInterfaz.PedirClave();
                                mInterfaz.PedirNombreP();
                                mInterfaz.PedirPrecio();
                                mInterfaz.PedirPrecioV();
                                mProducto.SetCalve(mInterfaz.GetClave());
                                mProducto.SetNombre(mInterfaz.GetNombreP());
                                mProducto.SetPrecio(mInterfaz.GetPrecio());
                                mProducto.SetPrecioV(mInterfaz.GetPrecioV());

                                mTienda.SetProducto(mProducto, i);
                                mArchivo.GuardarCoordenada(mProducto, mTienda);
                            }
                            mTienda.CalcularPC();
                            mTienda.CalcularPV();
                            mTienda.CalcularMaYMe();
                            mTienda.CalcularGanancia();
                            mArchivo.GuardarCoordenadaC(mProducto, mTienda);

                            mArchivo.GuardarCoordenada2(mProducto, mTienda);
                            mArchivo.GuardarCoordenada3(mProducto, mTienda);
                            mArchivo.GuardarCoordenada4(mProducto, mTienda);
                            mArchivo.GuardarCoordenada5(mProducto, mTienda);
                            mArchivo.GuardarCoordenadaCreador(mProducto, mTienda);
                        Console.WriteLine("\n");
                        
                        break;
                    case 2:
                        
                        mInterfaz.ImprimirCI(mTienda);
                        Console.ReadKey();
                        break;
                    case 3:
                        mInterfaz.ImprimirCV(mTienda);
                        Console.ReadKey();

                        break;
                    case 4:
                        
                        mInterfaz.ImprimirGanancia(mTienda);
                        Console.ReadKey();

                        break;
                    case 5:
                        mInterfaz.ImprimirMenor(mTienda, mProducto);
                        
                        Console.ReadKey();

                        break;
                    case 6:
                        mInterfaz.ImprimirMayor(mTienda, mProducto);
                        Console.ReadKey();

                        break;
                    case 7:
                        mInterfaz.ImprimirTiket(mTienda);
                        Console.ReadKey();

                        break;
                }
            } while (Opcion != 8);
            mArchivo.CerrarArchivo();
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}

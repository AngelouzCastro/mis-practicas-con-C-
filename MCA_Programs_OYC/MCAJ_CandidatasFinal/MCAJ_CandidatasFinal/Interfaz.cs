using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_CandidatasFinal
{
    class Interfaz
    {
        private string Nombre;
        private string Carrera;
        private string Talento;
        private int Votos;
        private int Opcion;
        private int Opcion2;

        Cand1 mCand1;
        Cand2 mCand2;
        Cand3 mCand3;

        public Interfaz()
        {
            mCand1 = new Cand1();
            mCand2 = new Cand2();
            mCand3 = new Cand3();
            Nombre = "";
            Carrera = "";
            Talento = "";
            Votos = 0;
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
            ImprimirOpcion(" M E N U ", ConsoleColor.Red, ConsoleColor.White, 50, 1);
            switch (sombreada)
            {
                case 1:
                    ImprimirOpcion(" Registrar candidatas  ", ConsoleColor.Yellow, ConsoleColor.Black, 40, 3);
                    ImprimirOpcion(" Emitir voto ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion(" Cerrar la votacion  ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 5);
                    ImprimirOpcion(" Salir ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;
                case 2:
                    ImprimirOpcion(" Registrar candidatas  ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion(" Emitir voto ", ConsoleColor.Yellow, ConsoleColor.Black, 40, 4);
                    ImprimirOpcion(" Cerrar la votacion  ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 5);
                    ImprimirOpcion(" Salir ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;
                case 3:
                    ImprimirOpcion(" Registrar candidatas  ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion(" Emitir voto ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion(" Cerrar la votacion  ", ConsoleColor.Yellow, ConsoleColor.Black, 40, 5);
                    ImprimirOpcion(" Salir ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;

                    case4:
                    ImprimirOpcion(" Registrar candidatas  ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion(" Emitir voto ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion(" Cerrar la votacion  ", ConsoleColor.Yellow, ConsoleColor.Black, 40, 5);
                    ImprimirOpcion(" Salir ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;

            }
        }

        public void ImprimirMen()
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
                        if (Opcion > 4)
                        {
                            Opcion = 1;
                        }
                        ImprimirMenu(Opcion);
                        break;
                    case ConsoleKey.UpArrow:
                        Opcion--;
                        if (Opcion < 1)
                        {
                            Opcion = 4;
                        }
                        ImprimirMenu(Opcion);
                        break;
                }
            } while (tecla.Key != ConsoleKey.Enter);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        public int GetOpcion()
        {
            return Opcion;
        }

        //vNombre

        public bool VerificarNombre()
        {
            bool correcto = false;

            if (Nombre.Length > 0)
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }

            if (correcto)
            {
                for (int i = 0; i < Nombre.Length; i++)
                {
                    if (!Char.IsLetter(Nombre[i]))
                    {
                        correcto = false;
                        break;
                    }
                }
            }

            if (correcto)
            {
                if (!Nombre.Contains("%"))
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










        public void PedirNombre()
        {
            bool correcto = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Dame el nombre de la candidata: ");
                try
                {
                    Nombre = Console.ReadLine();
                    correcto = VerificarNombre();
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (!correcto);
        }
        public string GetNombre()
        {
            return Nombre;
        }



        public void PedirCarrera()
        {
            bool correcto = false;
            do
            {
                Console.Write("Dame el Carrera de la candidata: ");
                try
                {
                    Carrera = Console.ReadLine();
                    correcto = VerificarNombre();
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (!correcto);
        }
        public string GetCarrera()
        {
            return Carrera;
        }




        public void PedirTalento()
        {
            bool correcto = false;
            do
            {
                Console.Write("Dame el Talento de la candidata: ");
                try
                {
                    Talento = Console.ReadLine();
                    correcto = VerificarNombre();
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    correcto = false;
                }
            } while (correcto == false);
        }
        public string GetTalento()
        {
            return Talento;
        }



        public void PedirVotos()
        {
            bool Correcto = false;

            do
            {
                Console.Write("Dame Votos de votos : ");
                try
                {
                    Votos = int.Parse(Console.ReadLine());
                    Correcto = true;
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    Correcto = false;
                }
            } while (Correcto == false);


        }
        public int GetVotos()
        {
            return Votos;
        }



        public void ImprimirResultados(Cand1 mCand1, Cand2 mCand2, Cand3 mCand3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El total de votos de " + mCand1.GetNombre() + " es  de " + mCand1.GetTotalVotos());
            Console.WriteLine("El total de votos de " + mCand2.GetNombre() + " es  de " + mCand2.GetTotalVotos());
            Console.WriteLine("El total de votos de " + mCand3.GetNombre() + " es  de " + mCand3.GetTotalVotos());
            if (mCand1.GetTotalVotos() > mCand2.GetTotalVotos() && mCand1.GetTotalVotos() > mCand3.GetTotalVotos())
            {
                Console.WriteLine("Reina: " + mCand1.GetNombre());
                if (mCand2.GetTotalVotos() > mCand3.GetTotalVotos())
                {
                    Console.WriteLine("Alteza real: " + mCand2.GetNombre());
                    Console.WriteLine("Princesa: " + mCand3.GetNombre());
                }
                else
                {
                    Console.WriteLine("Alteza real: " + mCand3.GetNombre());
                    Console.WriteLine("Princesa: " + mCand2.GetNombre());
                }

            }
            else if (mCand2.GetTotalVotos() > mCand1.GetTotalVotos() && mCand2.GetTotalVotos() > mCand3.GetTotalVotos())
            {
                Console.WriteLine("Reina: " + mCand2.GetNombre());
                if (mCand1.GetTotalVotos() > mCand3.GetTotalVotos())
                {
                    Console.WriteLine("Alteza real: " + mCand1.GetNombre());
                    Console.WriteLine("Princesa: " + mCand3.GetNombre());
                }
                else
                {
                    Console.WriteLine("Alteza real: " + mCand3.GetNombre());
                    Console.WriteLine("Princesa: " + mCand1.GetNombre());
                }
            }
            else
            {
                Console.WriteLine("Reina: " + mCand3.GetNombre());
                if (mCand1.GetTotalVotos() > mCand2.GetTotalVotos())
                {
                    Console.WriteLine("Alteza real: " + mCand1.GetNombre());
                    Console.WriteLine("Princesa: " + mCand2.GetNombre());
                }
                else
                {
                    Console.WriteLine("Alteza real: " + mCand2.GetNombre());
                    Console.WriteLine("Princesa: " + mCand1.GetNombre());
                }

            }

            Console.ReadKey();
        }




        public void ImprimirOpcion2(string texto, ConsoleColor color, ConsoleColor fondo, int posx, int posy)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = fondo;
            Console.SetCursorPosition(posx, posy);
            Console.WriteLine(texto);
        }


        public void ImprimirMenu2(int sombreada)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            ImprimirOpcion2(" C A N D I D A T A S ", ConsoleColor.Red, ConsoleColor.Black, 40, 1);
            switch (sombreada)
            {
                case 1:
                    ImprimirOpcion2("Candidata 1 ", ConsoleColor.Yellow, ConsoleColor.Black, 40, 3);
                    ImprimirOpcion2("Candidata 2 ", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion2("Candidata 3", ConsoleColor.Black, ConsoleColor.Yellow, 40, 5);
                    ImprimirOpcion2("Regresar", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;
                case 2:
                    ImprimirOpcion2("candidata 1", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion2("Candidata 2", ConsoleColor.Yellow, ConsoleColor.Black, 40, 4);
                    ImprimirOpcion2("Candidata 3", ConsoleColor.Black, ConsoleColor.Yellow, 40, 5);
                    ImprimirOpcion2("Regresar", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;
                case 3:
                    ImprimirOpcion2("candidata 1", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion2("Candidata 2", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion2("Candidata 3", ConsoleColor.Yellow, ConsoleColor.Black, 40, 5);
                    ImprimirOpcion2("Regresar", ConsoleColor.Black, ConsoleColor.Yellow, 40, 6);
                    break;
                case 4:
                    ImprimirOpcion2("candidata 1", ConsoleColor.Black, ConsoleColor.Yellow, 40, 3);
                    ImprimirOpcion2("Candidata 2", ConsoleColor.Black, ConsoleColor.Yellow, 40, 4);
                    ImprimirOpcion2("Candidata 3", ConsoleColor.Black, ConsoleColor.Yellow, 40, 5);
                    ImprimirOpcion2("Regresar", ConsoleColor.Yellow, ConsoleColor.Black, 40, 6);
                    break;
            }
        }

        public void ImprimirMenu2()
        {
            ImprimirMenu2(1);
            Opcion2 = 1;
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        Opcion2++;
                        if (Opcion2 > 4)
                        {
                            Opcion2 = 1;
                        }
                        ImprimirMenu2(Opcion2);
                        break;
                    case ConsoleKey.UpArrow:
                        Opcion2--;
                        if (Opcion2 < 1)
                        {
                            Opcion2 = 4;
                        }
                        ImprimirMenu2(Opcion2);
                        break;
                }
            } while (tecla.Key != ConsoleKey.Enter);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public int GetOpcion2()
        {
            return Opcion2;
        }

        public void ImprimirError(string Error)
        {
            Console.WriteLine("Error" + Error);
        }
    }
}

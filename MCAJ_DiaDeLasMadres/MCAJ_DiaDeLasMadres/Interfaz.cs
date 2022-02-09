using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks

namespace MCAJ_DiaDeLasMadres
{
    class Interfaz
    {
        private int Opcion;
        public Interfaz()
        {
            Opcion = 0;
        }
        public void ImprimirMenu(int Som)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            switch (Som) {
               
                case 1:
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("1. Mensaje Para Mamá");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2. Mensaje Para Hermana");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3. Mensaje Para Tía");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4. Mensaje Para Abuela");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("5. Salir");
            break;
                    case 2:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Mensaje Para Mamá");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("2. Mensaje Para Hermana");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("3. Mensaje Para Tía");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("4. Mensaje Para Abuela");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("5. Salir");
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Mensaje Para Mamá");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. Mensaje Para Hermana");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("3. Mensaje Para Tía");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("4. Mensaje Para Abuela");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("5. Salir");
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Mensaje Para Mamá");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. Mensaje Para Hermana");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("3. Mensaje Para Tía");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("4. Mensaje Para Abuela");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("5. Salir");
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Mensaje Para Mamá");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. Mensaje Para Hermana");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("3. Mensaje Para Tía");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("4. Mensaje Para Abuela");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("5. Salir");
                    break;

        }
        
        }
        public void ImprimirMenu()
        {
            ImprimirMenu(1);
            Opcion = 1;
            ConsoleKeyInfo tecala;
            do {
                tecala = Console.ReadKey(true);
                switch (tecala.Key)
                {
                    case ConsoleKey.DownArrow:
                        Opcion++;
                        if(Opcion > 5)
                        {
                            Opcion = 1;
                        }
                        ImprimirMenu(Opcion);
                        break;
                    case ConsoleKey.UpArrow:
                        Opcion--;
                        if(Opcion < 1)
                        {
                            Opcion = 5;
                        }
                        ImprimirMenu(Opcion);
                        break;
                }
                
            } while (tecala.Key != ConsoleKey.Enter);
        }

        public int GetOpcion()
        {
            return Opcion;
        }


        public void ImprimirMensaje()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Feliz Dia de Las Madres Mamá " +
                "\nA ti que me distestu vida, tu amor y tu espacio"+
"\n\nA ti que cargaste en tu vientre dolor y cansacio" +

"\n\nA ti que peleastes con uñas y dientes valiente en tu casa" +
"\nY en cualquier lugar" +
"\nA ti rosa fresca de abril a ti m fiel querubin" +

"\n\nA ti te dedico mis versos mis ser mis victorias a ti mis" +
"\nRespetos señora señora señora" +

"\n\nA ti mi guerrera invensible a ti luchadora incansable a ti" +
"\nMi amiga constante de todas las horas" +

"\n\nSu nombre es un nombre comun, como las margaritas siempre" +
"\nEn mi poca presencia constante en mi mente y para no hacer" +
"\nTanto alarde esa mujer de quien hablo es linda mi amiga gaviota" +
"\nSu no es...¡mi madre!" +

"\n\nA ti que me distes tu vida tu amor y tu espacio a ti que" +
"\nGuardastes en tu vientre dolor y cansacio" +

"\n\nA ti que peleastes con uñas y dientes valiente en tu casa" +
"\nY en cualquier lugar" +

"\n\nA ti rosa fresca de abril" +
"\nA ti mi fiel querubin" +
"\nA ti te dedico mis versos mi ser victorias" +
"\nA ti mis respetos señora señora señora" +

"\nY para no hacer tanto alarde" +
"\nDe esa mujer de quien hablo es linda mi amiga gaviota" +
"\nSu nombre es mi madre!!!!!");
            Console.ReadKey();
        }

        public void ImprimirmensajeH()
        {
           
            Console.WriteLine("Feliz dia de las madres Hermana, si es que heres mamá");
            Console.ReadKey();
        }
        
        public void ImprimirMensajeT()
        {
           
            Console.WriteLine("Feliz dia de las Madres tía");
            Console.ReadKey(); ;
        }
        public void ImprimirMensajeA()
        {
            
            Console.WriteLine("Feliz dia de las madres Abuela");
            Console.ReadKey();
        }

            
    }
}

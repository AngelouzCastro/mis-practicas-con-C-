using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Equipo1
{
    class Equipo
    {
        
            private string Nombre1;
            private int JG;
            private int JP1;
            private int JE1;
            private int JJ1;
            private string Nombre2;
            private int JG2;
            private int JP2;
            private int JE2;
            private int JJ2;
            private string Nombre3;
            private int JG3;
            private int JP3;
            private int JE3;
            private int JJ3;
            private int Puntos;
            private int Puntos2;
            private int Puntos3;
            public string Ganador;


            public Equipo()
            {
                Nombre1 = "";
                JG = 0;
                JP1 = 0;
                JE1 = 0;
                Nombre2 = "";
                JG2 = 0;
                JP2 = 0;
                JE2 = 0;
                Nombre3 = "";
                JG3 = 0;
                JP3 = 0;
                JE3 = 0;

            }

            public void SetNombre1(string Nombre1)
            {
                this.Nombre1 = Nombre1;
            }

            public void SetJG(int JG)
            {
                this.JG = JG;
            }

            public void SetJP1(int JP1)
            {
                this.JP1 = JP1;
            }

            public void SetJE1(int JE1)
            {
                this.JE1 = JE1;
            }

            public void CalcularJJ1()
            {
                JJ1 = 0;

                JJ1 = JG + JP1 + JE1;

            }


            public void CalcularPuntos()
            {

                Puntos = (JG * 3) + (JP1 * 0) + (JE1 * 1);
            }


            public void SetNombre2(string Nombre2)
            {
                this.Nombre2 = Nombre2;
            }

            public void SetJG2(int JG2)
            {
                this.JG2 = JG2;
            }

            public void SetJP2(int JP2)
            {
                this.JP2 = JP2;
            }

            public void SetJE2(int JE2)
            {
                this.JE2 = JE2;
            }

            public void CalcularJJ2()
            {
                JJ2 = 0;

                JJ2 = JG2 + JP2 + JE2;

            }


            public void CalcularPuntos2()
            {

                Puntos2 = (JG2 * 3) + (JP2 * 0) + (JE2 * 1);
            }


            public void SetNombre3(string Nombre3)
            {
                this.Nombre3 = Nombre3;
            }

            public void SetJG3(int JG3)
            {
                this.JG3 = JG3;
            }

            public void SetJP3(int JP3)
            {
                this.JP3 = JP3;
            }

            public void SetJE3(int JE3)
            {
                this.JE3 = JE3;
            }

            public void CalcularJJ3()
            {
                JJ3 = 0;

                JJ3 = JG3 + JP3 + JE3;

            }


            public void CalcularPuntos3()
            {

                Puntos3 = (JG3 * 3) + (JP3 * 0) + (JE3 * 1);
            }

            public void CalcularGanador()
            {
                if ((Puntos > Puntos2) && (Puntos > Puntos3))
                {
                    Ganador = Nombre1;
                }
                else if ((Puntos2 > Puntos) && (Puntos2 > Puntos3))
                {
                    Ganador = Nombre2;
                }
                else if ((Puntos3 > Puntos2) && (Puntos3 > Puntos))
                {
                    Ganador = Nombre3;
                }
                else if ((Puntos == Puntos2) && (Puntos > Puntos3))
                {
                    Ganador = Nombre1 + Nombre2;

                }
                else if ((Puntos == Puntos3) && (Puntos > Puntos2))
                {
                    Ganador = Nombre1 + " & " + Nombre3;
                }
                else if ((Puntos2 == Puntos3) && (Puntos2 > Puntos))
                {
                    Ganador = Nombre2 + " & " + Nombre3;
                }
                else if ((Puntos == Puntos2) && (Puntos2 == Puntos3))
                {
                    Ganador = Nombre1 + " & " + Nombre2 + " & " + Nombre3;
                }

            }

            public string GetNombre1()
            {
                return Nombre1;
            }

            public int GetJG()
            {
                return JG;
            }

            public int GetJP1()
            {
                return JP1;
            }

            public int GetJE1()
            {
                return JE1;
            }

            public int GetJJ1()
            {
                return JJ1;
            }

            public int GetPuntos()
            {
                return Puntos;
            }

            public string GetNombre2()
            {
                return Nombre2;
            }

            public int GetJG2()
            {
                return JG2;
            }

            public int GetJP2()
            {
                return JP2;
            }

            public int GetJE2()
            {
                return JE2;
            }

            public int GetJJ2()
            {
                return JJ2;
            }

            public int GetPuntos2()
            {
                return Puntos2;
            }

            public string GetNombre3()
            {
                return Nombre3;
            }

            public int GetJG3()
            {
                return JG3;
            }

            public int GetJP3()
            {
                return JP3;
            }

            public int GetJE3()
            {
                return JE3;
            }

            public int GetJJ3()
            {
                return JJ3;
            }

            public int GetPuntos3()
            {
                return Puntos3;
            }



        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumnolol
{
    class Alumno
    {
        private string NC;
        private String Nombre;
        private Materia[] ListaMaterias;
        private float Promedio;

        public Alumno(int NumeroMaterias)
        {
         NC = "";
         Nombre = "";
         ListaMaterias = new Materia[NumeroMaterias];
         Promedio = 0;
        }

        public void SetNC(string NC)
        {
            this.NC = NC;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetMateria(Materia mMateria, int Posicion)
        {
            ListaMaterias[Posicion] = mMateria;
        }

        public void CalcularPromedio()
        {
            float Suma = 0;
            int i;

            for (i = 0; i < ListaMaterias.Length; i++)
            {
                Suma = Suma + ListaMaterias[i].GetPromedio();
            }

            Promedio = Suma / ListaMaterias.Length;
        }

        public string GetNC()
        {
            return NC;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public Materia GetMateria(int Posicion)
        {
            return ListaMaterias[Posicion];
        }

        public float GetPromedio()
        {
            return Promedio;
        }
        public int GetNumeroUnidades()
        {
            return ListaMaterias.Length;
        }

        public int GetNumeroMateria()
        {
            return ListaMaterias.Length;
        }
    }
}

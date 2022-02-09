using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Candidatas
{
    class Candidatas
    {
        public string Nombre;
        public string Carrera;
        public string Talento;
        public int Votos;

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetCarrera(string carrera)
        {
            this.Carrera = carrera;
        }

        public void SetTalento(string Talento)
        {
            this.Talento = Talento;
        }

        public void SetVotos(int Votos)
        {
            this.Votos = Votos;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetCarrera()
        {
            return Carrera;
        }

        public string GetTalento()
        {
            return Talento;
        }

        public int GetVotos()
        {
            return Votos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_CandidatasFinal
{
    class Candidatas
    {
        protected string Nombre;
        protected string Carrera;
        protected string Talento;
        protected int Votos;
        protected int TotalVotos;

        public Candidatas()
        {
            Nombre = "";
            Carrera = "";
            Talento = "";
            TotalVotos = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }


        public void SetCarrera(string Carrera)
        {
            this.Carrera = Carrera;
        }
        public string GetCarrera()
        {
            return Carrera;
        }


        public void SetTalento(string Talento)
        {
            this.Talento = Talento;
        }
        public string GetTalento()
        {
            return Talento;
        }




        public void SetVotos(int Votos)
        {
            this.Votos = Votos;
        }
        public int GetVotos()
        {
            return Votos;
        }
    }
}

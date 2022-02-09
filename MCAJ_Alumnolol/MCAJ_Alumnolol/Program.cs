using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumnolol
{
    class Program
    {
        private Interfaz mInterfaz;
        private Materia mMateria;
        private Unidad mUnidad;
        private Alumno mAlumno;

        public Program()
        {
            mInterfaz = new Interfaz();
            mAlumno = new Alumno();
        }

        public void Correr()
        {
            int Opc;
            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                switch(Opc)
                {
                    case 1:
                        mInterfaz.PedirNumeroMaterias();
                        mAlumno = new Alumno(mInterfaz.GetNumeroMaterias());
                        mInterfaz.PedirNC();
                        mInterfaz.PedirNombreAlumno();
                        mAlumno.SetNombre(mInterfaz.GetNombreAlumno());
                        mInterfaz.PedirNumeroUnidades();
                        for (int i= 0; i < mAlumno.GetNumeroMateria(); i++) { 
                        mMateria = new Materia(mInterfaz.GetNumeroUnidad());
                }
            }
        }

        static void Main(string[] args)
        {
             
        }
    }
}

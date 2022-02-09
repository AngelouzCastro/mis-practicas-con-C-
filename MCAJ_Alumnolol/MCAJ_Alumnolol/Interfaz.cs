using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumnolol
{
    class Interfaz
    {
        private string NC;
        private string Clave;
        private string NombreAlumno;
        private string NombreMateria;
        private string NombreUnidad;
        private float Calificacion;
        private int NumeroUnidades;
        private int NumeroMaterias;
        private int Opcion;

        public Interfaz()
        {
         NC = "";
         Clave = "";
         NombreAlumno = "";
         NombreMateria = "";
         NombreUnidad = "";
         Calificacion = 0;
         NumeroUnidades = 0;
         NumeroMaterias = 0;
         Opcion = 0;
        }

    

    public void PedirNC()
    {
        Console.Write("Dame número de control: ");
            NC = Console.ReadLine();
    }

    public void PedirNombreAlumno()
    {
        Console.WriteLine("Dame nombre alumno: ");
            NombreAlumno = Console.ReadLine();
    }

    public void PedirNombreMateria()
    {
            Console.WriteLine("Dame nombre de la materia: ");
            NombreMateria = Console.ReadLine();
    }

     public void PedirNomeroUnidad()
    {
        Console.WriteLine("Dame nombre de la unidad: ");
            NombreUnidad = Console.ReadLine();
    }

    public void PedirNumeroUnidades()
    {
            Console.WriteLine("Dame número de unidades: ");
            NumeroUnidades = int.Parse(Console.ReadLine());
    }

    public void PedirNumeroMaterias()
    {
            Console.WriteLine("Dame número de materia: ");
            NumeroMaterias = int.Parse(Console.ReadLine());
    }
    
    public void ImprimirMenu()
    {
       Console.WriteLine("MENU DE OPCIONES");
       Console.WriteLine("1. Alta de alumno");
       Console.WriteLine("2. Mostrar alumno");
       Console.WriteLine("3. Salir");
       Console.WriteLine("Elige opción: ");
       Opcion = int.Parse(Console.ReadLine());
    }

    public string GetNC()
    {
            return NC;
    }

    public string GetNombreAlumno()
    {
        return NombreAlumno;
    }

    public string GetNombreMateria()
    {
        return NombreMateria;
    }

    public int GetNumeroUnidad()
    {
        return NumeroUnidades;
    }

    public int GetNumeroMaterias()
    {
        return NumeroMaterias;
    }

    public int GetOpcion()
    {
        return Opcion;
    }
    
    public void ImprimirAlumno(Alumno mAlumndo)
        {
            //mAlumndo.GetMateria(0).GetUnidad(0).GetNombre();
            Materia mMateria;
            Unidad mUnidad;
            int i, j;

            Console.WriteLine("NC: " + mAlumndo.GetNC());
            Console.WriteLine("Nombre: " + mAlumndo.GetNombre());
            Console.WriteLine("Promedio: " + mAlumndo.GetPromedio());
            for (i=0; i < mAlumndo.GetNumeroMateria(); i++)
            {
                Console.WriteLine("\tClave: " + mMateria.GetClave());
                Console.WriteLine("\tNombre: " + mMateria.GetNombre());
                Console.WriteLine("\tPromedio: " + mMateria.GetPromedio());
                for(j = 0; j < mMateria.GetUnidad(); j ++)
                {
                    mUnidad = mMateria.GetUnidad(j);
                    Console.WriteLine("\t\tNombre: " + mUnidad.GetNombre());
                    Console.WriteLine("\t\tCalificacion: " + mUnidad.GetCalifcacion());
                }
            }
        }
    
    }
}

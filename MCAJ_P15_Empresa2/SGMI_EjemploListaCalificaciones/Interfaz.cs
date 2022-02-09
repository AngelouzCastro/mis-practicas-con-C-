using System;

namespace SGMI_EjemploListaCalificaciones
{
    class Interfaz
    {
        private string NC;
        private string NombreAlumno;
        private string Clave;
        private string NombreMateria;
        private string NombreUnidad;
        private float Calificacion;
        private int NumeroUnidades;
        private int NumeroMaterias;
        private int Opcion;

        public Interfaz()
        {
            NC = "";
            NombreAlumno = "";
            Clave = "";
            NombreMateria = "";
            NombreUnidad = "";
            Calificacion = 0;
            NumeroUnidades = 0;
            NumeroMaterias = 0;
            Opcion = 0;
        }

       

        public void PedirNombreAlumno()
        {
            Console.Write("Dame nombre del la empresa: ");
            NombreAlumno = Console.ReadLine();
        }

       

        public void PedirNombreMateria()
        {
            Console.Write("Dame nombre del Departamento: ");
            NombreMateria = Console.ReadLine();
        }

        public void PedirNombreUnidad()
        {
            Console.Write("Dame nombre del Empleado: ");
            NombreUnidad = Console.ReadLine();
        }

        public void PedirCalificacion()
        {
            Console.Write("Dame Pago Empleado: ");
            Calificacion = float.Parse(Console.ReadLine());
        }

        public void PedirNumeroUnidades()
        {
            Console.Write("Dame número de Empleados: ");
            NumeroUnidades = int.Parse(Console.ReadLine());
        }

        public void PedirNumeroMaterias()
        {
            NumeroMaterias = 3;
            /*Console.Write("Dame número de Departamentos: ");
            NumeroMaterias = int.Parse(Console.ReadLine());*/
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Alta de Empresa(SOlo 3 Departamentos)");
            Console.WriteLine("2. Mostrar Empresa");
            Console.WriteLine("3. Salir");
            Console.Write("Elige opción: ");
            Opcion = int.Parse(Console.ReadLine());
        }

        
        public string GetNombreAlumno()
        {
            return NombreAlumno;
        }
        
        public string GetNombreMateria()
        {
            return NombreMateria;
        }
        public string GetNombreUnidad()
        {
            return NombreUnidad;
        }
        public float GetCalificacion()
        {
            return Calificacion;
        }
        public int GetNumeroUnidades()
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

        public void ImprimirAlumno(Empresa mAlumno)
        {
            // Una forma
            // mAlumno.GetMateria(0).GetUnidad(0).GetNombre();
            Departamento mMateria;
            Empleado mUnidad;
            int i;
            int j;

            Console.WriteLine("E M P R E S A");
            
            Console.WriteLine("Nombre: " + mAlumno.GetNombre());
            Console.WriteLine("Pago Total: " + mAlumno.GetPromedio());
            for (i = 0; i < mAlumno.GetNumeroMaterias(); i++)
            {
                mMateria = mAlumno.GetMateria(i);
                Console.WriteLine("\tD E P A R T A M E N T O");
                Console.WriteLine("\tNombre: " + mMateria.GetNombre());
                Console.WriteLine("\tPago por departamento: " + mMateria.GetPromedio());
                for (j = 0; j < mMateria.GetNumeroUnidades(); j++)
                {
                    mUnidad = mMateria.GetUnidad(j);
                    Console.WriteLine("\t\tE M P L E A D O");
                    Console.WriteLine("\t\tNombre: " + mUnidad.GetNombre());
                    Console.WriteLine("\t\tPago Empleado: " + mUnidad.GetCalificacion());
                }
            }
        }
    }
}

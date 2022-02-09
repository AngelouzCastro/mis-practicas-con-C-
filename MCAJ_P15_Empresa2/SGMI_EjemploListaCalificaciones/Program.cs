
namespace SGMI_EjemploListaCalificaciones
{
    class Program
    {
        private Interfaz mInterfaz;
        private Empresa mAlumno;
        private Departamento mMateria;
        private Empleado mUnidad;

        public Program()
        {
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int opc;
            int i;
            int j;

            do
            {
                mInterfaz.ImprimirMenu();
                opc = mInterfaz.GetOpcion();

                switch (opc)
                {
                    case 1:
                        
                        mInterfaz.PedirNombreAlumno();
                        mInterfaz.PedirNumeroMaterias();
                        mAlumno = new Empresa(mInterfaz.GetNumeroMaterias());
                        
                        mAlumno.SetNombre(mInterfaz.GetNombreAlumno());
                        for (i = 0; i < mAlumno.GetNumeroMaterias(); i++)
                        {
                            
                            mInterfaz.PedirNombreMateria();
                            mInterfaz.PedirNumeroUnidades();
                            mMateria = new Departamento(mInterfaz.GetNumeroUnidades());
                            
                            mMateria.SetNombre(mInterfaz.GetNombreMateria());
                            for (j = 0; j < mMateria.GetNumeroUnidades(); j++)
                            {
                                mUnidad = new Empleado();
                                mInterfaz.PedirNombreUnidad();
                                mUnidad.SetNombre(mInterfaz.GetNombreUnidad());
                                mInterfaz.PedirCalificacion();
                                mUnidad.SetCalificacion(mInterfaz.GetCalificacion());
                                mMateria.SetUnidad(mUnidad, j);
                            }
                            mMateria.CalcularPromedio();
                            mAlumno.SetMateria(mMateria, i);
                        }
                        mAlumno.CalcularPromedio();
                        break;
                    case 2:
                        mInterfaz.ImprimirAlumno(mAlumno);
                        break;
                }
            } while (opc != 3);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}

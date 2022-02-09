
namespace SGMI_EjemploListaCalificaciones
{
    class Departamento
    {

        private string Nombre;
        private Empleado[] ListaUnidades;
        private float Promedio;

        public Departamento(int NumeroUnidades)
        {

            Nombre = "";
            ListaUnidades = new Empleado[NumeroUnidades];
            Promedio = 0;
        }



        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetUnidad(Empleado mUnidad, int Posicion)
        {
            ListaUnidades[Posicion] = mUnidad;
        }

        public Empleado GetUnidad(int Posicion)
        {
            return ListaUnidades[Posicion];
        }

        public void CalcularPromedio()
        {
            float Suma;
            int i;

            Suma = 0;
            for (i = 0; i < ListaUnidades.Length; i++)
            {
                Suma = Suma + ListaUnidades[i].GetCalificacion();
            }

            Promedio = Suma;
        }



        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPromedio()
        {
            return Promedio;
        }

        public int GetNumeroUnidades()
        {
            return ListaUnidades.Length;
        }
    }
}

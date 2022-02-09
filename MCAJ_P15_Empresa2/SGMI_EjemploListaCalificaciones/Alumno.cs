
namespace SGMI_EjemploListaCalificaciones
{
    class Empresa
    {

        private string Nombre;
        private Departamento[] ListaMaterias;
        private float Promedio;

        public Empresa(int NumeroMaterias)
        {

            Nombre = "";
            ListaMaterias = new Departamento[NumeroMaterias];
            Promedio = 0;
        }



        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetMateria(Departamento mMateria, int Posicion)
        {
            ListaMaterias[Posicion] = mMateria;
        }

        public void CalcularPromedio()
        {
            float Suma;
            int i;

            Suma = 0;
            for (i = 0; i < ListaMaterias.Length; i++)
            {
                Suma = Suma + ListaMaterias[i].GetPromedio();
            }

            Promedio = Suma;
        }



        public string GetNombre()
        {
            return Nombre;
        }

        public Departamento GetMateria(int Posicion)
        {
            return ListaMaterias[Posicion];
        }

        public float GetPromedio()
        {
            return Promedio;
        }

        public int GetNumeroMaterias()
        {
            return ListaMaterias.Length;
        }
    }
}


namespace SGMI_EjemploListaCalificaciones
{
    class Empleado
    {
        private string Nombre;
        private float Calificacion;

        public Empleado()
        {
            Nombre = "";
            Calificacion = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetCalificacion(float Calificacion)
        {
            this.Calificacion = Calificacion;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetCalificacion()
        {
            return Calificacion;
        }
    }
}

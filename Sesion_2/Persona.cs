namespace Sesion_2
{
    public class Persona
    {
        public Persona()
        {
           Nombre=string.Empty;
            Edad = 0;
        }
        public string Nombre { get; set; }
        public int Edad { get; set;}

        private void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public int GetEdad()
        {
            setNombre("Antonio");
            return Edad;
        }

       
    }
}

namespace Tarea2
{
      abstract class Persona
    {
        public int Id { get; set; }

        private string cedula;

        public string GetCedula()
        {
            return cedula;
        }

        public void SetCedula(string value)
        {
            cedula = value;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string caminar()
        {

            return $"Puedo Caminar\n";
        }
    }
    
    
}

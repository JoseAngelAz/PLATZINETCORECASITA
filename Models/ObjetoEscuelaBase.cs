namespace aspnetcore_platzi.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }
        //lo agregue yo
        public string Descripción { get; set; }
        public ObjetoEscuelaBase()
        {
            //UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}
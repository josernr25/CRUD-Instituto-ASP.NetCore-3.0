using System;

namespace InstitutoCore3._0.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}
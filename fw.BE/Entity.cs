using System;
using fw.Interfaces;

namespace fw.Entities
{
    public abstract class Entity : IBaseEntity
    {
        public string ID { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }
        public string dvh { get; set; }
    }
}
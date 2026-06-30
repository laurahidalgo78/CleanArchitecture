using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Reviews
{
    public sealed class Review: Entity
    {
        public Guid VehiculoId { get; private set; }
        public Guid AlquilerId { get; private set; }
        public Guid UserId { get; private set;}
        public int Rating {  get; private set; }
        public string? Comentario {  get; private set; }

    }
}

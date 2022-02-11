using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryTravel.Models
{
    public partial class Libros
    {
        public Libros()
        {
            AutoresHasLibros = new HashSet<AutoresHasLibro>();
        }

        public int Isbn { get; set; }
        public int? EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }

        public virtual Editoriales Editoriales { get; set; }
        public virtual ICollection<AutoresHasLibro> AutoresHasLibros { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryTravel.Models
{
    public partial class AutoresHasLibro
    {
        public int AutoresId { get; set; }
        public int LibrosIsbn { get; set; }

        public virtual Autores Autores { get; set; }
        public virtual Libros LibrosIsbnNavigation { get; set; }
    }
}

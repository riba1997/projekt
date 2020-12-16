using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace projekt.Models
{
    [Table("Kategoria")]
    public class Kategoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}

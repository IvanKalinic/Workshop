using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Speaker
    {

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public int Name { get; set; }

        [StringLength(1000)]
        public string Bio { get; set; }

        [StringLength(200)]
        public virtual string WebSite { get; set; }

    }
}

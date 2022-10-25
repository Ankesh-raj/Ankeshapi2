using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Colour
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid colourId { get; set; }

        public string colourName { get; set; }

        public string colourCode { get; set; }
    }
}
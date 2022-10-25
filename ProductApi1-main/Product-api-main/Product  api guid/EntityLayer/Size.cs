using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Size
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid sizeId { get; set; }

        public string sizeName { get; set; }
    }
}

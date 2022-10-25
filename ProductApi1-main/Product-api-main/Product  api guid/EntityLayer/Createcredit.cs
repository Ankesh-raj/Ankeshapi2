using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public  class Createcredit
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int creditId { get; set; }
        public DateTime createDate { get; set; }

        public string createdBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace EntityLayer
{
    public class Product
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid productId { get; set; }

        public string productName { get; set; }



        public int productYear { get; set; }
        public int channelId { get; set; }



        public string productCode { get; set; }

        [ForeignKey("size")]
        public Guid sizeScaleId { get; set; }

        public Size size { get; set; }

        public List<Article> articles { get; set; }




    }
}


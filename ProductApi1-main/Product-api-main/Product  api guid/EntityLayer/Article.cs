using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace EntityLayer
{
    public class Article
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ArticleId { get; set; }
        public string ArticleName { get; set; }

        [ForeignKey("colour")]
        public Guid colourId { get; set; }

        public Colour colour { get; set; }
    }
}

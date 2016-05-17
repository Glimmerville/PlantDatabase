using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class LeafShapeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeafShapeID { get; set; }
        [Display(Name ="Leaf Shape")]
        public string LeafShapeStyle { get; set; }
    }
}
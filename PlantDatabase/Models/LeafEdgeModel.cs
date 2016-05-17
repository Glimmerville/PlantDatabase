using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class LeafEdgeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeafEdgeID { get; set; }

        [Display(Name ="Leaf Edges Shape")]
        public string LeafEdges { get; set; }
    }
}
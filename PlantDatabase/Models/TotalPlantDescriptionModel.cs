using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class TotalPlantDescriptionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlantDescriptionID { get; set; }

        [Display(Name ="Scientific Name ID")]
        public int PlantCoreID { get; set; }

        [Display(Name ="Plant Name ID")]
        public int PlantCommonID { get; set; }

        [Display(Name ="Flower Color ID")]
        public int BloomColorID { get; set; }

        [Display(Name ="Plant Leaf Arrangement ID")]
        public int PlantLeafArrID { get; set; }

        [Display(Name ="Plant Leaf Shape ID")]
        public int LeafShapeID { get; set; }

        [Display(Name ="Leaf Edge Style ID")]
        public int LeafEdgeID { get; set; }
    }
}
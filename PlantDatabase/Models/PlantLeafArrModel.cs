using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class PlantLeafArrModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlantLeafArrID { get; set; }
        [Display(Name="Leaf Arrangement")]
        public string PlantLeafArr { get; set; }

        //foreign key
        //public int PlantCoreID { get; set; }
    }
}
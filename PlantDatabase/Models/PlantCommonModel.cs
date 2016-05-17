using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class PlantCommonModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlantCommonID { get; set; }
        [Display(Name="Plant Common Name")]
        public string PlantCommon { get; set; }
        //foreign key
        [Display(Name="Reference ID for Sci Name")]
        public int PlantCoreID { get; set; }

    }
}
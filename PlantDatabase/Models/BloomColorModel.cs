using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class BloomColorModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloomColorID { get; set; }
        [Display(Name="Blossom Color")]
        public string FlowerColor { get; set; }
        //foreign key
        //public int PlantCoreID { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlantDatabase.Models
{
    public class PlantCoreModel
    {
        [Key]
        public int PlantCoreID { get; set; }
        public string PlantSciName { get; set; }
        
        //These are all going to be foreign keys 
        //Put the FK in the other table, relate it back here
        //don't put the FK in here.
        //if the plan only has one option you can put the FK in here (?)

        //public int PlantCommonID { get; set; } //many
        //public int FlowerShapeID { get; set; }
        //public int PlantLeafArrID { get; set; }
        //public int PlantLeafMarginID { get; set; }
        //public int PlantBloomMonID { get; set; } //many
        //public int FlowerColorID { get; set; } //many

        //I am going to start with just these above ^^^^^
    }
    
    /* 
    So an image could connect to a controller that fires off a query somehow.
    models generally evolve and add features later.
    start with an MVP 


    A plant can only have ONE core scientific name (for the purposes of this app)
    A plant can only have ONE flower shape (simple/compund/umbrella/spike/assymetrical)
    A plant can only have ONE leaf arrangement (opposite, alternate, or whorled, or basal)
    A plant can only have ONE leaf margin (confirm this)
    A plant can only have ONE leaf tip (Not sure this is important at all, but round or pointed)
    A plant can only be ONE of hairy or smooth (confirm this)

    A plant can have MANY plant common names
    A plant can have MANY flower colors (such as "pink or white")
    A plant can have MANY bloom months (such as April through June)

    A plant height can be very subjective, not sure if I should use this.
    A plant flower size can be subjective but should have an average (under an inch / over an inch)
    */
}
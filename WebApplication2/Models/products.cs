using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{//khanoom teymoorian
    public class products
    {
        public int Id { get; set; }

        [Display(Name = "Brand Name")]
        //khanoom hekmatii
        public string BrandName { get; set; }
        [Display(Name = "Brand INO")]

        //aghaye taghiipoor
        public string ModeINO { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public int fieldId { get; set; }
        public virtual field Field { get; set; }



    }
}
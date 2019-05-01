using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class products
    {
        public int Id { get; set; }

        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        [Display(Name = "Brand INO")]
        public string ModeINO { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
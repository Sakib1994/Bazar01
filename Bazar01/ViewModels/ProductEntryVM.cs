using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bazar01.ViewModels
{
    public class ProductEntryVM
    {
        public string Title { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public string Unit { get; set; }


        [Display(Name = "Item In Stock")]
        public int ItemInStock { get; set; }

        public int PlaceId { get; set; }

        public int CategoryId { get; set; }

        //IMAGE
        [Display(Name = "Image Path")]
        public IFormFile ImagePath { get; set; }
    }
}

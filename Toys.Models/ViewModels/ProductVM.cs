﻿namespace Toys.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        [ValidateNever]
        
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}

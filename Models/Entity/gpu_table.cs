//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class gpu_table
    {
        public int GPUID { get; set; }

        [Required(ErrorMessage ="GPU NAME REQUIRED")]
        public string GPUNAME { get; set; }
        [Required(ErrorMessage = "GPU CATEGORY REQUIRED")]
        public Nullable<short> GPUCATEGORY { get; set; }
        [Required(ErrorMessage = "GPU CORE CLOCK REQUIRED")]
        public Nullable<int> GPUCORECLOCK { get; set; }
        [Required(ErrorMessage = "GPU MEMORY CLOCK REQUIRED")]
        public Nullable<int> GPUMEMORYCLOCK { get; set; }
        [Required(ErrorMessage = "GPU MAX MEMORY REQUIRED")]
        public string GPUMAXMEMORY { get; set; }
        [Required(ErrorMessage = "GPU PRICE REQUIRED")]
        public Nullable<decimal> GPUPRICE { get; set; }
        [Required(ErrorMessage = "GPU G3D MARK POINT REQUIRED")]
        public Nullable<int> GPUG3D { get; set; }
    
        public virtual category_table category_table { get; set; }
    }
}

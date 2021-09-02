using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using deneme.Models.Entity;
using System.Web.Mvc;
using System.Data.Entity;

namespace deneme.db_extension
{
    public class ViewDataItems
    {
        public List<SelectListItem> CategoryList { get; set; }
        //public System.Data.Entity.DbSet<gpu_table> table { get; set; }
        //public System.Data.Entity.DbSet<deneme.Models.Entity.category_table> myvalues { get; set; }

       
    }
}
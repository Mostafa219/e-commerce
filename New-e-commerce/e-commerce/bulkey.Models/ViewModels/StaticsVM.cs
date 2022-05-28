
using bulkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkey.Models.ViewModels
{
    public class StaticsVM
    {
        public IEnumerable<Product> Product { get; set; }

        public IEnumerable<Compan> Compan { get; set; }
        public IEnumerable<CoverType> CoverType { get; set; }

        public IEnumerable<ApplicationUser> ApplicationUser { get; set; }

        public IEnumerable<OrderHeader> OrderHeaders { get; set; }

        public IEnumerable<Category> Category { get; set; }


    }
}




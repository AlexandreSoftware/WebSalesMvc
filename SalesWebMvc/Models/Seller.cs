using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class Seller {
        public Department department { get; private set; }
        internal void removedepartment() {
            department = null;
        }
    }
}

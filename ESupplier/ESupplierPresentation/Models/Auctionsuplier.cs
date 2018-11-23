using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESupplierPresentation.Models
{
    using System;
    using System.Collections.Generic;

    public class Auctionsuplier
    {
        public String offer { get; set; }
        public short win { get; set; }
        public Supplier suplier { get; set; }
    }
}
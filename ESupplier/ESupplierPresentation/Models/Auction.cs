using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESupplierPresentation.Models
{
    using System;
    using System.Collections.Generic;

    public class Auction
    {
        public long idauction { get; set; }
        public String startdate { get; set; }
        public String closedate { get; set; }
        private List<Auctionsuplier> auctionsuplierList { get; set; }
        private List<Product> productList { get; set; }
        private int idUser { get; set; }
        private String username { get; set; }
}
}
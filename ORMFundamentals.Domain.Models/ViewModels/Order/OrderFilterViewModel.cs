using System;
using System.Collections.Generic;
using System.Text;

namespace ORMFundamentals.Domain.Models.ViewModels.Order
{
    public class OrderFilterViewModel
    {
        public int? ProductID { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Status { get; set; }
    }
}

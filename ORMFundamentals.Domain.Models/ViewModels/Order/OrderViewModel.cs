﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ORMFundamentals.Domain.Models.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ProductId { get; set; }
    }
}

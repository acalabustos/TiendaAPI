﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem
    {
        public object IdProduct;

        public int IdUser { get; set; }
        public int IdOrder { get; set; }
        public int ProductId { get; set; }
        public decimal Lot { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
        public bool IsPayed { get; set; }
    }
}

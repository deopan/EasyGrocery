﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGrocery.Common.Entities
{
    public class ShippingEntity
    {
        public int CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}

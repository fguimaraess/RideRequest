﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RideRequest.Model
{
    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string LocationId { get; set; }
        public string DisplayName { get; set; }
        public string FullDisplayName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RideRequest.Model
{
    public class AddressDetail
    {
        Address Address { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}

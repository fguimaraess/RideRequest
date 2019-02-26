using System;
using System.Collections.Generic;
using System.Text;

namespace RideRequest.Model
{
    public class Suggestions
    {
        public List<Suggestion> suggestions { get; set; }
    }

    public class Suggestion
    {
        public string label { get; set; }
        public string language { get; set; }
        public string countryCode { get; set; }
        public string locationId { get; set; }
        public Address Address { get; set; }
        public string matchLevel { get; set; }
    }
}


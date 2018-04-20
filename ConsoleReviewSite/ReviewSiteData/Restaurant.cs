﻿using System.Collections.Generic;

namespace ReviewSiteData
{
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public IList<Review> Reviews { get; set; }
    }
}

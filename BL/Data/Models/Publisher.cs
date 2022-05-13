using System;
using System.Collections.Generic;

namespace BL.Data.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string publisherName { get; set; }

        public List<Book> books { get; set; }

    }

}

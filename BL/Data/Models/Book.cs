using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Data.Models
{
    public class Book
    {
        public int id { get; set; }
        public string bookName { get; set; }

        public string author { get; set; }

        public string shortDesc { get; set; }

        public string longDesc { get; set; }

        public int pagesCount { get; set; }

        public ushort price { get; set; }

        public string img { get; set; }

        public bool available { get; set; }

        public bool isFavorite { get; set; }

        public int publihserID { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}

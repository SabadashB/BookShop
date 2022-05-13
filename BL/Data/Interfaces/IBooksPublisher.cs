using BL.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Data.Interfaces
{
    interface IBooksPublisher
    {
        IEnumerable<Publisher> allPublishers { get; }

    }
}

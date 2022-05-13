using BL.Data.Interfaces;
using BL.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Data.Mocks
{
    public class MockPublisher : IBooksPublisher
    {
        public IEnumerable<Publisher> allPublishers
        {
            get
            {
                return new List<Publisher>
                {
                    new Publisher { publisherName = "Книжковий клуб"},
                    new Publisher { publisherName = "Центрполіграф"}
                };
            }
        }
    }
}

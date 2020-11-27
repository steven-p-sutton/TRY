using System;
using System.Collections.Generic;
using System.Text;

namespace SQLCoreApp.Model
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
    }
    public class WidgetModel
    {
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Secret { get; set; } // not included in DTO version of class.
    }
}

using System;

namespace SQLCoreApp.Model
{
    public class WidgetModel
    {
        public long Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Secret { get; set; } // not included in DTO version of class.
    }
}

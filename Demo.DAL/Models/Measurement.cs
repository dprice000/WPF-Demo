using System;

namespace Demo.DAL
{
    public class Measurement
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; }
        public string DateType { get; set; }
        public string Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

using System;

namespace Demo.DAL.Models
{
    public class Measurement
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

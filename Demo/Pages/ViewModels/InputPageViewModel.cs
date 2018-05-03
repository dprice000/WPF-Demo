using System;

namespace Demo.Pages
{
    public class InputPageViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

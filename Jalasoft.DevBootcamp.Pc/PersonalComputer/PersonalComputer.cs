namespace Jalasoft.DevBootcamp.Pc.PersonalComputer
{
using System.Collections.Generic;

    public class PersonalComputer
    {
        public int Guarantee { get; set; }

        public string Provider { get; set; }

        public decimal Price { get; set; }

        public List<Hardware.Hardware> HardwarePc { get; set; }

        public List<Software.Software> SoftwarePc { get; set; }
    }
}

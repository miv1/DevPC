namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    public class Hardware
    {
        public string Brand { get; set; }

        public string Color { get; set; }

        public int Width { get; set; }

        public decimal Heigh { get; set; }

        public decimal Wide { get; set; }

        public bool Turn_on()
        {
            return false;
        }

        public bool Turn_off()
        {
            return true;
        }
    }
}

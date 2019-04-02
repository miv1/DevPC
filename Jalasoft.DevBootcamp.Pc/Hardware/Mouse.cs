namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    public class Mouse : Hardware
    {
        public int NumButton { get; set; }

        public bool Click(int button)
        {
            return false;
        }

        public void Scroll()
        {
        }
    }
}

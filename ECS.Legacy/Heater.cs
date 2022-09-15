namespace ECS.Legacy
{
    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
        bool RunSelfTest();
    }

    public class Heater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    public class CopyOfHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("CopyOfHeater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("CopyOfHeater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
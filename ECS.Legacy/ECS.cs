using System;

namespace ECS.Legacy
{
    public class ECS
    {
        public int _threshold
        {
            get;
            set;

        } 
        private  ITempSensor _tempSensor;
        
        public IHeater _heater
        {
            get ; set;
        }=new Heater();

        public ECS(int thr, ITempSensor sen)
        {
            _threshold=thr;
            _tempSensor = sen;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

      
        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}

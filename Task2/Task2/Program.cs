using System;

namespace Task2
{
    interface IRadio
    {
        void Play();
    }

    interface IAlarmClock
    {
        void Ring(DateTime time);
    }

    class Radio : IRadio
    {
        public Radio() {} 

        public void Play()
        {
            Console.WriteLine("Радио играет!");
        }
    }

    class AlarmClock : IAlarmClock
    {
        private DateTime _ringTime;

        public AlarmClock(DateTime ringTime)
        {
            _ringTime = ringTime;
        }

        public void Ring(DateTime time)
        {
            if (_ringTime.Equals(time))
            {
                Console.WriteLine("Будильник звонит!");
            }
        }
    }

    class RadioAlarmClock : IRadio, IAlarmClock
    {
        private DateTime _ringTime;

        public RadioAlarmClock(DateTime ringTime)
        {
            _ringTime = ringTime;
        }

        public void Play()
        {
            Console.WriteLine("Радиобудульник играет!");
        }

        public void Ring(DateTime time)
        {
            if(_ringTime.Equals(time));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

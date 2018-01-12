using System;
using System.Runtime.Serialization;

namespace WindowsFormsApplication3
{
    [Serializable]
    internal class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException():
            base ("На парковке нет корабля по такому месту")
        { }
    }
}
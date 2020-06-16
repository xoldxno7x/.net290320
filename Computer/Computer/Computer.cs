using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    [System.Diagnostics.DebuggerDisplay("Model = {model}, Price = {price*3.67}")]
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn = false;

        public int TellMeThePrice()
        {
            return this.price;
        }

        public float TellMeTheScreenSize()
        {
            return this.screenSize;
        }

        public void TurnOn()
        {
            this.isTurnOn = true;
        }
        public void TurnOff()
        {
            this.isTurnOn = false;
        }

        public void AddProcessor()
        {
            this.numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"Computer: Model - {model}, Price - {price}, NumberOfProcessors - {numberOfProcessors}, ScreenSize - {screenSize}, isTurnOn - {isTurnOn}";
        }
    }
}

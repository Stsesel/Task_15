using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class ArithProgression : ISeries
    {
        double step;
        double startValue;
        double currentValue;

        public double getNext()
        {
            currentValue+=step;
            return currentValue;
        }

        public void reSet()
        {
            currentValue = startValue;
        }

        public void setStart(double x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void setStep(double s)
        {
            step = s;
        }
    }
}
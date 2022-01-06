using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    interface ISeries
    {
        void setStart(double x);
        double getNext();
        void reSet();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithTwoWindowsForms
{
    public class MyGetNextNumber : IGetNextNumber
    {
        public int LastAssignedNumber = 0;
        public int GetNextNumber()
        {
            LastAssignedNumber++;
            return LastAssignedNumber;
        }
    }
}

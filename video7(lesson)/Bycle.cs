using System;
using System.Collections.Generic;
using System.Text;

namespace video7_lesson_
{
    class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}

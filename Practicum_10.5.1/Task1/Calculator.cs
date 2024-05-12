using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Calculator : ICalculator
    {
        float ICalculator.Add(float x, float y)
        {
            return x + y;
        }
    }
}
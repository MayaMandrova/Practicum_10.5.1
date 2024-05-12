using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculator : ICalculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public float Add(float x, float y)
        {
            float result = x + y;
            _logger.Event($"сложение {x} и {y}");
            return result;
        }
    }
}
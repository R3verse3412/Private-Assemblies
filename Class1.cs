using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class BasicCalcu
    {
        public float addition(float number1, float number2)
        {
            float result = number1 + number2;
            return result;
        }

        public float subtractiion(float number1, float number2)
        {
            float result = number1 - number2;
            return result;
        }

        public float multiplication(float number1, float number2)
        {
            float result = number1 * number2;
            return result;
        }

        public float division(float number1, float number2)
        {
            float result = number1 / number2;
            return result;
        }
    }
}

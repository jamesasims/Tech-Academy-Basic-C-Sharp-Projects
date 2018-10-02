using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes3
{
    class MathOperation
    {
        public int IntOperation(int i)
        {
            int answer1 = i + 15;
            return answer1;
        }
        public int IntOperation(decimal i)
        {
            decimal answer1 = i + 20;
            return Convert.ToInt32(answer1);
        }
        public int IntOperation(string i)
        {
            if (int.TryParse(i, out int inputInt))
            {
                int answer1 = inputInt + 40;
                return answer1;
            }

            return 0000;
        }
    }

}

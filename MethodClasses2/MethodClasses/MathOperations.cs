using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClasses
{
    public class MathOperations
    {

        public static int AdditionOperation(int input, int answer)
        {
            answer = input + 26;
            return answer;
           
        }
        public static int MultiplicationOperation(int input, int answer2)
        {
            answer2 = input * 5;
            return answer2;
        }
        public static int SubtractionOperation(int input, int answer3)
        {
            answer3 = input - 4;
            return answer3;
        }
            
            public int answer3 { get; set; }
            public int answer2 { get; set; }
            public int answer { get; set; }
            public int input { get; set; }


    }

        
 }


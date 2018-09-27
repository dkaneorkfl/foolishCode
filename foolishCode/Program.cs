using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foolishCode
{
    class Program
    {
        #region 오늘의 바보같은 코드 1
        //노드의 앞뒤를 잇고 끊는 방법이랑 int값을 옮기기 위해 임시값 temp를 만드는 것은 같은 이미지라고 볼 수 있을까? 한번 실험해보자.

        //
        #endregion

        #region 학습용
        //피보나치 수열과 하노이의 탑
        #endregion

        public static int Fibonacci(int n)
        {
            
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
                
            }
        }

        public static void Main(string[] arg)
        {
            

            Console.WriteLine(Fibonacci(6));
        }
    }
}

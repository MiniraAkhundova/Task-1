using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Method
    {
        /// <summary>
        /// Here is located our function minRoofLength(int[] cars, int k)
        /// 1.here we take res value's initial value as max value of integer 
        /// 2.then we have to sort our array because our numbers are unordered
        /// 3.we look at the case if cars array length =k .
        /// if it does we just have to cars[cars.Length - 1] - cars[0] + 1;
        /// 4. then in loop we have to to compare max value with cars[i + k - 1] - cars[i]
        /// and we get an answer
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int carParkingRoof(int[] cars, int k)
        {
            ////The full explanation you will get in README file !!!!!!
            int res = int.MaxValue;
            Array.Sort(cars);
            if (cars.Length == k)
            {
                return cars[cars.Length - 1] - cars[0] + 1;
            }

            for (int i = 0; i < cars.Length - k; i++)
            {
                res = Math.Min(res, cars[i + k - 1] - cars[i]); 
            }
            return res + 1;
          
        }
    }
}

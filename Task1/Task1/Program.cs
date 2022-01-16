using System;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// Here by creating the object of Method class 
        /// where is replaced our Function we can get the minimum length of the roof.
        /// We have to pass to this function 2 pharametres,namely:
        /// array of our cars that are parked 
        /// and
        /// the number roofs that are possible to cover by roof
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //The full explanation you will get in README file !!!!!!
            int[] arr = new int[] { 6, 2, 12, 7 };
            Method newObject = new Method();
            Console.WriteLine($"The minimum length of the roof is : { newObject.carParkingRoof(arr, 3)}");
        }
    }
}

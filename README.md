Parking Dilemma
 There are many cars parked in a parking lot. The parking lot is a straight
 line with a parking spot for every meter. There are n cars currently
 parked and a roofer wants to cover them with a roof. The requirement is
 that at least k cars are covered by the roof. Determine the minimum length
 of the roof that will cover k cars.
 Example
 n=4
cars=[6, 2, 12, 7]
k=3
Two roofs that cover three cars are possible: one covering spots 2 through 7 with a length of 6, and another covering slots 6 through 12 with a length of 7. 
The shortest roof that meets the requirement is of length 6.

Answer+Explanation:
Here I have writed  carParkingRoof Function on C#.
We look at our task in this way:
For instanse,we have an array and we have to find a group of this array.
In our array we have such element 6, 2, 12, 7.So our n=4 and k=3,that is why we must find subarray of this array whick consists from 3 elements,+ there is a contion that:
"Two roofs that cover three cars are possible".
We can solve this task like O(n),O(n^2) or O(n*k),but we will choose the fastest and chortest way,namely  O(n).
If we have an array,group [] and fixed length ,we can use sliding through theese groups.
We have to cover with roof theese cars,but we must find the minimum length of the roof.
Sliding through theese groups(arrays) will look like that we will change positions.
Initially,we must find minumum throught theese groups that is why we must to calculate the fastest.
As telling example we can choose the minum length 6 we is concentrated our element:2,4,5,6,7 and among them 2,6 are common with cars array.
So the max value here is 5 and because 7-2=5.
The min value is:2 if look at combination 2,3,4,so that 4-2=2.
We can look for such combination through all array (from 1 to 12).
Our k=3 ,so we can find one of the min .Example:
we look at 2,3,4,where 4-2=2,so that 4's index number is 3 and 2's 1,that is why
4-->1,3
So that min=cars[3]-arr[i]
The number of theese min is infinite.
So we write a Function in other class ,where we give to our function two parametres:int[] cars, int k.

     public int carParkingRoof(int[] cars, int k)
        {
        //We take here res as Max Value of Int to compare at the end
       
            int res = int.MaxValue;
        //Here i must notice that that our cars array is unordered so that we must paste each element on its right order
        
            Array.Sort(cars);
            
            //if this group's length is equal to 3 
            //then 12-1=11 is position - cars[0] +1
            
            
            if (cars.Length == k)
            {
                return cars[cars.Length - 1] - cars[0] + 1;
            }

//and we iterate our loop
//cars.Length - k:12-3 to appopriative position

//our res variable will change its value to the minimum ,namely cars[i + k - 1] - cars[i]

            for (int i = 0; i < cars.Length - k; i++)
            {
                res = Math.Min(res, cars[i + k - 1] - cars[i]); 
            }
            return res + 1;
          
        }




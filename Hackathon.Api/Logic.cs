// A Hello World! program in C#.
using System;
using System.Linq;
using System.Collections.Generic;
namespace Hackathon.Api
{
    public class Logic
    {
         public  int[] CalConsecutiveNumber (int N) 
        {
            List<Consecutive> consecutiveResult = new List<Consecutive>();

            // Note that we don't 
            // ever have to sum
            // numbers > ceil(N/2)
            int start = 1;
            int end = (N + 1) / 2;

            // Repeat the loop
            // from bottom to half
            while (start < end)
            {
                // Check if there exist 
                // any sequence from 
                // bottom to half which
                // adds up to N
                int sum = 0;
                for (int i = start; i <= end; i++)
                {
                    sum = sum + i;

                    // If sum = N, this means 
                    // consecutive sequence exists
                    if (sum == N)
                    {
                        // found consecutive 
                        // numbers! print them
                        for (int j = start; j <= i; j++)
                        {
                            consecutiveResult.Add(new Consecutive { i = i, j = j });
                            //Console.Write(j + " ");
                        }
                        //Console.WriteLine();


                        break;
                    }

                    // if sum increases N then
                    // it can not exist in the 
                    // consecutive sequence 
                    // starting from bottom
                    if (sum > N)
                        break;
                }
                sum = 0;
                start++;
            }    

            var pp = consecutiveResult.Select(x => x.i).Max();
            var oo = consecutiveResult.Where(x => x.i == pp).Select(item =>item.j);
            return oo.ToArray();
            
        }

        public CountMoney Pay (int price,int pay)  {

            int result = pay - price;
//            int countThousand;
//            int countFiveHundred;
//            int countHundred;
//            int countFifty;
//            int countTwenty;
//            int countTenCoin;
//            int countFiveCoin;
//            int countOneCoin;
            CountMoney cm = new CountMoney();
            
            if(result > 1000) {
                
                cm.countThousand = result / 1000;
                result =  result - (cm.countThousand * 1000);
            }

                
            if(result > 500) {
                
               cm.countFiveHundred = result / 500;
               result = result - (cm.countFiveHundred * 500);
            }

            if(result >100) {
                cm.countHundred = result / 100;
                result = result - (cm.countHundred * 100);
            }

            if(result > 50) {
                cm.countFifty = result / 50;
                result = result - (cm.countFifty * 50);
             }

                                    
            if(result > 20) {
                cm.countTwenty = result / 20;
                result = result - (cm.countTwenty * 20);
            }

                                            
            if(result >10) {
                cm.countTenCoin = result / 10;
                result = result - (cm.countTenCoin * 10);
            }

            if(result > 5) {
                cm.countFiveCoin = result / 5;
                result = result - (cm.countFiveCoin * 5);
            }

            if(result > 1) {
                cm.countOneCoin = result / 1;
            }
            
            return cm;

        }
   }
        
   public class CountMoney {       
       public int countThousand { get ; set;} 
       public int countFiveHundred { get ; set;} 
       public int countHundred { get ; set;} 
       public int countFifty { get ; set;} 
       public int countTwenty { get ; set;} 
       public int countTenCoin { get ; set;} 
       public int countFiveCoin { get ; set;} 
       public int countOneCoin { get ; set;}       
       
   }

   public class Consecutive
    {
        public int i { get; set; }
        public int j { get; set; }
    }
        
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Jose__Hernandez_comp212_sec003_Exercise2
{

  public static class MethodExtension
    {   
        
        //method to count elements of Builder
        public static int CountWords(this StringBuilder builder)
        {
            var Count = builder.Length ;
         
            Console.WriteLine("your StringBuilder contians {0} elements ", Count);

            return Count;
        }

    }
}

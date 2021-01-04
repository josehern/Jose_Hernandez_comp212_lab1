using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Jose__Hernandez_comp212_sec003_Exercise2
{
    class MethodExtensionTest
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                // append to StringBuilder.
                builder.Append(i).Append(" ");
            }
            Console.WriteLine("{0}", builder);

          
          MethodExtension.CountWords(builder);
            
        }
    }
}

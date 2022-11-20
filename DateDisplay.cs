using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ToolKit
{
    abstract class DateDisplay
    {
        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}

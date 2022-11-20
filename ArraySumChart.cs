using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ToolKit
{
    class IntArraySumChart
    {
        private int[,] chart;

        public IntArraySumChart(int[] arr, bool canBeRightLeft = false)
        {
            chart = new int[arr.Length, arr.Length];

            if (canBeRightLeft)
            {
                for (int row = 0; row < arr.Length; row++)
                {
                    for (int col = row + 1; col < arr.Length; col++)
                    {
                        chart[row, col] = chart[row, col - 1] + arr[col];
                    }
                }
            }
            else
            {
                for (int row = 0; row < arr.Length; row++)
                {
                    chart[row, row] = arr[row];

                    for (int col = row + 1; col < arr.Length; col++)
                    {
                        chart[row, col] = chart[row, col - 1] + arr[col];
                    }
                }
            }

        }
    }

}

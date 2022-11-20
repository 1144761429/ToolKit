namespace Assets.Scripts.ToolKit
{
    class IntArraySumChart
    {
        private int[,] chart;

        public IntArraySumChart(int[] arr)
        {
            chart = new int[arr.Length, arr.Length];

            for (int row = 0; row < chart.GetLength(0); row++)
            {
                chart[row, row] = arr[row];

                for (int col = row + 1; col < chart.GetLength(1); col++)
                {
                    chart[row, col] = chart[row, col - 1] + arr[col];
                }
            }
        }

        /// <summary>
        /// Print the IntArraySumChart
        /// </summary>
        public void Print()
        {
            string printedChart = "";

            for (int row = 0; row < chart.GetLength(0); row++)
            {
                for (int col = 0; col < chart.GetLength(1); col++)
                {
                    printedChart += chart[row, col] + " ";
                }
                printedChart += "\n";
            }

            Console.WriteLine(printedChart.Substring(0, printedChart.Length - 2));
        }

        /// <summary>
        /// Get the summation of values of an int array through its corresponding IntArraySumChart
        /// </summary>
        /// <param name="left">The left bound(inclusive)</param>
        /// <param name="right">The right bound(inclusive)</param>
        /// <returns>The summation of the values on the interval</returns>
        /// <exception cref="ArgumentException">Thrown when left bound is greater than right bound; or the left and right index are out of range</exception>
        public int GetSum(int left, int right)
        {
            if (left > right)
            {
                throw new ArgumentException("Left bound cannot be greater then the right bound.");
            }

            if (left < 0 || right >= chart.GetLength(0))
            {
                throw new ArgumentException("Left bound or right bound is out of range.");
            }

            return chart[left, right];
        }

        /// <summary>
        /// Get the summation of values of an int array through its corresponding IntArraySumChart
        /// </summary>
        /// <returns>The summation of the values in an int array</returns>
        public int GetSum()
        {
            return chart[0, chart.GetLength(0) - 1];
        }
    }
}

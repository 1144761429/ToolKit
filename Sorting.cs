using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Assets.Scripts.ToolKit
{
    abstract class Sorting
    {
        /// <summary>
        /// Swap two values at specified indices in an int array
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <param name="arr"></param>
        private static void Swap(int index1, int index2, int[] arr)
        {
            (arr[index2], arr[index1]) = (arr[index1], arr[index2]);
        }

        /// <summary>
        /// Using selection sort to sort an int array. The original array will not change.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>A newly created, sorted int array</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter arr is null</exception>
        public static int[] SelectionSort(int[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length < 2)
            {
                return arr;
            }

            int[] copiedArr = new int[arr.Length];
            arr.CopyTo(copiedArr, 0);

            for (int i = 0; i < copiedArr.Length - 1; i++)
            {
                int smallestValueIndex = i;

                for (int j = i + 1; j < copiedArr.Length; j++)
                {
                    smallestValueIndex = copiedArr[smallestValueIndex] > copiedArr[j] ? j : smallestValueIndex;
                }

                Swap(i, smallestValueIndex, copiedArr);
            }

            return copiedArr;
        }

        /// <summary>
        /// Using bubble sort to sort an int array. The original array will not change.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>A newly created, sorted int array</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter arr is null</exception>
        public static int[] BubbleSort(int[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length < 2)
            {
                return arr;
            }

            int[] copiedArr = new int[arr.Length];
            arr.CopyTo(copiedArr, 0);

            for (int i = copiedArr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (copiedArr[j] > copiedArr[j + 1])
                    {
                        Swap(j, j + 1, copiedArr);
                    }
                }
            }

            return copiedArr;
        }

        /// <summary>
        /// Using insertion sort to sort an int array. The original array will not change.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>A newly created, sorted int array</returns>
        /// <exception cref="ArgumentNullException">Thrown when the parameter arr is null</exception>
        public static int[] InsertionSort(int[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length < 2)
            {
                return arr;
            }

            int[] copiedArr = new int[arr.Length];
            arr.CopyTo(copiedArr, 0);

            for (int end = 1; end < copiedArr.Length; end++)
            {
                for (int pre = end - 1; pre >= 0 && copiedArr[pre] > copiedArr[pre + 1]; pre--)
                {
                    Swap(pre, pre + 1, copiedArr);
                }
            }

            return copiedArr;
        }
    }
}


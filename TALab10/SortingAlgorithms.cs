using System;
using System.Collections.Generic;
using System.Linq;

namespace TALab10.DataSorting
{
    public class SortingAlgorithms
    {
        public static void BubbleSort(List<int> array)
        {
            if (array.Count <= 1) return;

            bool swapped = true;

            while (swapped == true)
            {
                swapped = false;

                for (int i = 1; i < array.Count; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        (array[i - 1], array[i]) = (array[i], array[i - 1]);
                        swapped = true;
                    }
                }
            }
        }

        public static void QuickSort(List<int> array)
        {
            if (array.Count <= 1) return;

            Random random = new Random();

            int randomElem = array[random.Next(array.Count)];

            var leftArray = new List<int>();
            var rightArray = new List<int>();
            var middleArray = new List<int>();

            foreach (int elem in array)
            {
                if (elem < randomElem)
                {
                    leftArray.Add(elem);
                }
                else if (elem > randomElem)
                {
                    rightArray.Add(elem);
                }
                else
                {
                    middleArray.Add(elem);
                }
            }

            QuickSort(leftArray);
            QuickSort(rightArray);
            leftArray.AddRange(middleArray); 
            leftArray.AddRange(rightArray);
            array.Clear();
            array.AddRange(leftArray);
        }

        public static void MergeSort(List<int> array)
        {
            if (array.Count <= 1) return;

            int firstMidIndex = array.Count / 3;
            int secondMidIndex = firstMidIndex * 2;

            var leftArray = new List<int>();
            var middleArray = new List<int>();
            var rightArray = new List<int>();

            for (int i = 0; i < array.Count; i++)
            {
                if (i <= firstMidIndex)
                {
                    leftArray.Add(array[i]);
                }
                else if (i <= secondMidIndex)
                {
                    middleArray.Add(array[i]);
                }
                else
                {
                    rightArray.Add(array[i]);
                }
            }

            MergeSort(leftArray);
            MergeSort(middleArray);
            MergeSort(rightArray);
            array.Clear();
            array.AddRange(Merge(Merge(leftArray, middleArray), rightArray));
        }

        private static List<int> Merge(List<int> firstArray, List<int> secondArray)
        {
            var array = new List<int>();
            
            int k = 0;
            int j = 0;

            while (k < firstArray.Count && j < secondArray.Count)
            {
                if (firstArray[k] <= secondArray[j])
                {
                    array.Add(firstArray[k]);
                    k++;
                }
                else
                {
                    array.Add(secondArray[j]);
                    j++;
                }
            }

            if (k < firstArray.Count)
            {
                for (int g = k; g < firstArray.Count; g++)
                {
                    array.Add(firstArray[g]);
                }
            }
            if (j < secondArray.Count)
            {
                for (int g = j; g < secondArray.Count; g++)
                {
                    array.Add(secondArray[g]);
                }
            }

            return array;
        }

        public static void HeapSort(List<int> array)
        {
            if (array.Count <= 1) return;

            for (int i = array.Count / 2 - 1; i >= 0; i--)
            {
                CreateHeap(array, array.Count, i);
            }
            for (int i = array.Count - 1; i >= 0; i--)
            {
                (array[i], array[0]) = (array[0], array[i]);
                CreateHeap(array, i, 0);
            }
        }

        private static void CreateHeap(List<int> array, int size, int index)
        {
            var largestIndex = index;
            var leftChild = 2 * index + 1;
            var rightChild = 2 * index + 2;

            if (leftChild < size && array[leftChild] > array[largestIndex])
            {
                largestIndex = leftChild;
            }

            if (rightChild < size && array[rightChild] > array[largestIndex])
            {
                largestIndex = rightChild;
            }

            if (largestIndex != index)
            {
                (array[largestIndex], array[index]) = (array[index], array[largestIndex]);
                CreateHeap(array, size, largestIndex);
            }
        }

        public static void LSDSort(List<int> array, int maxNumber)
        {
            if (array.Count <= 1) return;

            for (int exponent = 1; maxNumber / exponent > 0; exponent *= 10)
            {
                var outputArr = new List<int>(new int[array.Count]);
                var occurences = new List<int>(new int[10]);

                for (int i = 0; i < array.Count; i++)
                    occurences[(array[i] / exponent) % 10]++;
                for (int i = 1; i < 10; i++)
                    occurences[i] += occurences[i - 1];
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                    occurences[(array[i] / exponent) % 10]--;
                }
                for (int i = 0; i < array.Count; i++)
                    array[i] = outputArr[i];
            }
        }

        public static void MSDSort(List<int> array, int maxNumber)
        {
            if (array.Count <= 1) return;

            int exp = (int)Math.Pow(10, maxNumber.ToString().Length - 1);

            MSD(array, exp);
        }

        private static void MSD(List<int> array, int exponent)
        {
            if (exponent < 1 || array.Count <= 1) return;

            var outputArr = new List<int>(new int[array.Count]);
            var occurences = new List<int>(new int[10]);

            for (int i = 0; i < array.Count; i++)
                occurences[(array[i] / exponent) % 10]++;
            for (int i = 1; i < 10; i++)
                occurences[i] += occurences[i - 1];
            for (int i = array.Count - 1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }
            for (int i = 0; i < array.Count; i++)
                array[i] = outputArr[i];

            var buffer = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                var partArr = new List<int>();
                partArr.AddRange(array.Where(x => (x / (10 * exponent) % 10 == i)));
                MSD(partArr, exponent / 10);
                buffer.AddRange(partArr);
            }

            array.Clear();
            array.AddRange(buffer);
        }
    }
}

using System;
using System.Linq;

class Solution
{
    static void InsertionSort2(int n, int[] arr)
    {
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }

        ShowArray(arr);
    }

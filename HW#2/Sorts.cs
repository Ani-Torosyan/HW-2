using System;

namespace HW_2
{
    public static class Sorts
    {
        public static void insertionSort(int[] arr, int n)
        {
            if(n <= 1) return;

            insertionSort(arr , n-1);

            int last = arr[n -1];
            int j = n - 2;

            while (j >= 0 && arr[j] > last)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = last;
        }

        public static void selectionSort(int[] arr, int n, int ind)
        {
            if(ind == n) return;

            int min = arr[ind];
            int minInd = ind;

            for(int i = ind + 1; i < n; i++) 
            {
                if(arr[i] < min) 
                {
                    min = arr[i];
                    minInd = i;
                }
            }

            arr[minInd] = arr[ind];
            arr[ind] = min;

            ind++;

            selectionSort(arr, n, ind);
        }
    }
}

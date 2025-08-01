using System;

public class InsertionSort
{
    public void Sort(int[] arr, int len)
    {
        for (int i = 1; i < len; i++)
        {
            int temp = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = temp;
        }
    }

    public void Print(int[] arr, int len)
    {
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
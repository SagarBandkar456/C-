using System;

public class FindPeak162
{
    public int FindPeakElement(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;

            if (nums[mid] < nums[mid] + 1)
                l = mid;
            else
                r = mid;
        }

        return nums[l] > nums[r] ? l : r;
    }
}
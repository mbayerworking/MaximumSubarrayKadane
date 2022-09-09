///<summary>
/// Given array X[] of n integers, write a program to find the maximum sum
/// of subarray among all subarrays.
/// --A subarray of array X[] is a contiguous segment of elements from
/// through X[j], where 0 <= i <= j <= n
/// --If array contains all non-negative numbers, the maximum subarray
/// sum would be the sum of entire array.
/// --Several different sub-arrays may have the same max sum, but we
/// just need to return the value of max subarray sum.
///</summary>

///<summary>
/// Example 1:
/// Input: X[] = [-4,5,7,-6,10,-15,3], Output: 16
/// Explanation: The subarray [5,7,-6,10] has the maximum sum.
///</summary>
///<summary>
/// Example 2:
/// Input: X[] = [-3,2,-1,4,-2], Output: 5
/// Explanation: The subarray [2,-1,4] has the maximum sum.
///</summary>
///<summary>
/// Example 3:
/// Input: X[] = [5,7,6,10,3], Output: 31
/// Explanation: All array elements are non-negative. So the maximum
/// subarray sum would be the sum of the entire array.
///</summary>

/// <remarks>
/// Discussed solution approaches
/// 1) A brute force approach using three nested loops
/// 2) Using two nested loops
/// 3) Using divide and conquer idea similar to the merge sort
/// 4) Using dynamic programming: Using single loop and O(n) space
/// 5) Kadane algorithm: Using single loop and variables
/// </remarks>
Console.WriteLine("Test");

int[] x = new int[]{-4,5,7,-6,10,-15,3};
Console.WriteLine(getMaxSubarraySum(x, x.Length));
Console.WriteLine();
Console.WriteLine(getMaxSubarraySum2(x, x.Length));
//Brute force solution
int getMaxSubarraySum(int[] X, int n)
{
    int maxSubarraySum = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = i; j < n; ++j)
        {
            int subarraySum = 0;
            for( int k = i; k <= j; ++k)
            {
                subarraySum = subarraySum +X[k];
            }
            if(subarraySum > maxSubarraySum)
            {
                maxSubarraySum = subarraySum;
            }
        }
    }
    return maxSubarraySum;
}

int getMaxSubarraySum2(int[] X, int n)
{
    int maxSubarraySum = 0;
    for (int i = 0; i < n; ++i)
    {
        int subarraySum = 0;
        for (int j = i; j < n; ++j)
        {
            subarraySum = subarraySum + X[j];
            if(subarraySum > maxSubarraySum)
            {
                maxSubarraySum = subarraySum;
            }
        }
    }
    return maxSubarraySum;
}


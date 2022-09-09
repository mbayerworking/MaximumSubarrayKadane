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
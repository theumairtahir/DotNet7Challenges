﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DotNet7Challenges;

public class Challenges
{
    /*
    Challenge 1:
    Write a program that takes an integer as input and returns the sum of all the integers from 1 to that input number.

    Constraints:

    The input number can be in the range of 1 to 10^6
    Example:
    Input: 5
    Output: 15 (1+2+3+4+5 = 15)

    This problem requires you to:

    accept an input from the user
    use a loop to iterate from 1 to the input number
    perform an operation (addition) during each iteration
    output the final result
    You have to solve the problem using all the loops (for, while, do while, foreach) and recursion
    */
    public int AddTillNumber(int number)
    {
        int n = number;
        //int sum = 0;

        //if (number < 0)
        //{
        //    for (int i = -1; i >= n; i--)
        //    {
        //        sum += i;
        //    }
        //}
        //else
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //}

        //Sum of natural numbers using while loop
        //int j = 0;
        //int sum = 0;
        //if (number < 0)
        //{
        //    j = -1;
        //    while (j >= n)
        //    {
        //        sum += j;
        //        j--;
        //    }
        //}
        //else
        //{
        //    while (j < n)
        //    {
        //        j++;
        //        sum += j;

        //    }
        //}

        // Sum of natural numbers using do while loop
        //if (number == 0)
        //{
        //    return 0;
        //}
        //int k = 0;
        //int sum = 0;
        //if (number < 0)
        //{
        //    do
        //    {
        //        k--;

        //        sum += k;

        //    } while (k > number);


        //}

        //else
        //{
        //    do
        //    {
        //        k++;
        //        sum += k;

        //    } while (k < n);
        //}

        //Sum of natural numbers using foreach loop
        int[] a = new int[Math.Abs(n)];


        for (int i = 0; i < a.Length; i++)
        {
            a[i] = number > 0 ? i + 1 : n + i;
        }

        int sum = 0;
        foreach (int l in a)
        {
            sum += l;
        }
        //Sum of natural numbers using recursion

        // int sum = Sum(n);
        return sum;
    }

    public static int Sum(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n > 0) { return n + Sum(n - 1); }
        else
        {
            return n + Sum(n + 1);
        }
    }

    /*Challenge 2:
    Create a method ReverseString(string input) that takes a string as an input and returns the string reversed.
    For example, ReverseString("hello") should return "olleh".
    You can use any data structures or algorithms you see fit to solve the problem (But you have to implement at least 3 different logics). 
    */
    public string ReverseString(string str)
    {
        return null;
    }

    /*Challenge 3:
    Create a method FindMissingNumber(int[] numbers) that takes an array of integers as an input and returns the missing number in the array.
    The array will always be of length n-1 and will contain integers from 1 to n. The missing number will be an integer from 1 to n.
    For example, FindMissingNumber([1, 3, 4]) should return 2.
    You can use any data structures or algorithms you see fit to solve the problem.
    */
    public int FindMissingNumber(int[] arr)
    {
        return default;
    }

    /*
    Challenge 4: Create a method called FindLongestSubstringWithoutRepeatingCharacters(string s) 
    that takes in a string and returns the length of the longest substring without repeating characters.
    Example:
    Input: "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.

    Input: "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.

    HINT: You can use sliding window technique to solve this problem.

    */
    public int FindLongestSubstringWithoutRepeatingCharacters(string s)
    {
        return default;
    }
}

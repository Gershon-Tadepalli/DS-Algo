﻿using System;
using DS_AlgoLibrary.Arrays;
using DS_AlgoLibrary.LinkedList;
using DS_AlgoLibrary.SortingAndSearching;
using DS_AlgoLibrary.Strings;
using DSAlgoLibrary.Arrays;

namespace DS_AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = string.Empty;
            do
            {
                Console.WriteLine("Choose your option to select DS Topic : ");
                Console.WriteLine("Press 'A' for Arrays");
                Console.WriteLine("If you want to exit press 'X' or 'Exit'");
                option = Console.ReadLine();
                PickTopic(option.ToUpper());
            } while (option.ToUpper()!="X");
        }

        static void PickTopic(string _option)
        {
            switch (_option)
            {
                case "A":

                    //Arrays

                    //TrapWater

                    int[] height = { 1, 2, 3, 9, 8, 7 };
                    TrapWater trapWater = new TrapWater();
                    int trappedWater = trapWater.Trap(height);
                    Console.WriteLine($"Trapped water for given array heights is : {trappedWater}");

                    //StockSpan

                    int[] prices = { 7, 1, 5, 3, 6, 4 };
                    StockSpan sp = new StockSpan();
                    Console.WriteLine($"Max profit we can make from the given prices : {sp.MaxProfit(prices)}");


                    //Remove Duplicates in Sorted Array
                    int[] duplicateArray = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
                    RemoveDuplicatesOfSortedArray rd = new RemoveDuplicatesOfSortedArray();
                    int length = rd.RemoveDuplicates(duplicateArray);
                    Console.WriteLine("Array after removing duplicates:");
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($" {duplicateArray[i]} ,");
                    }
                    Console.WriteLine();
                    //Reverse A string
                    char[] reverseStringIp = {'h', 'e', 'l', 'l', 'o'};
                    Console.WriteLine("Input string to Reverse: ");
                    foreach (var item in reverseStringIp)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    ReverseAString reverse = new ReverseAString();
                    reverse.ReverseString(reverseStringIp);

                    //valid Palindrome
                    string palindromInput = "race a car";
                    Palindrome PalindromeIp = new Palindrome();
                    bool status = PalindromeIp.IsPalindrome(palindromInput);
                    Console.WriteLine($"Given string is Palindrome or not : {status}");

                    //First Bad Version
                    FirstBadVersion version = new FirstBadVersion();
                    version.firstBadVersion = 5;
                    int firstBadVersion = version.FindFirstBadVersion(8);
                    if (version.firstBadVersion == firstBadVersion) Console.WriteLine($"First Bad verison found at : {firstBadVersion}");
                    break;
                case "LL":

                    LinkedList linkedList = new LinkedList();
                    linkedList.InsertAtEnd(10);
                    linkedList.InsertAtEnd(20);
                    linkedList.InsertAtEnd(30);

                    ReverseALinkedList reverseALinkedList = new ReverseALinkedList();
                    ListNode newHead = reverseALinkedList.ReverseList(linkedList.head);
                    Console.WriteLine();
                    linkedList.printList(newHead);
                    break;

                default:
                    Console.WriteLine("Invalid option Selected");
                    break;

                    
            }
        }
    }
}

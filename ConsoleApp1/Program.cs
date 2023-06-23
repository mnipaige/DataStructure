// using DataStructure.HeapSort;
using DataStructure.KMP;

// See https://aka.ms/new-console-template for more information

// HeapSort
// int[] arr = new int[]{ 4, 10, 3, 8, 1, 5 };
// HeapSortProgram.HeapSort(arr, arr.Length);
// HeapSortProgram.PrintArr(arr);

//KMP
string heystack = "aabaacaabaaf";
string needle = "aabaaf";
int result = KMPProgram.strStr(heystack, needle);

Console.WriteLine("Hello, World!");


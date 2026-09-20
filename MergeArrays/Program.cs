using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace MergeArrays;

public class Program
{
        public static void Main(string[] args)
    {
        /*string[] names1 = ["andrea", "clay"];
        string[] names2 = ["ben", "drew"];
        var sortedNames = MergeSortedArrays(names1, names2);
        System.Console.WriteLine(string.Join(", ", sortedNames));*/

    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] yes = new int[array1.Length + array2.Length];
        int counter1 = 0;
        int counter2 = 0;
        for (int i=0; i<(array1.Length+array2.Length); i++)
            {
                
                if (counter1 >= array1.Length)
                    yes[i] = array2[counter2++];

                else if (counter2 >= array2.Length)
                    yes[i] = array1[counter1++];

                else if (array1[counter1] <= array2[counter2])
                {
                    yes[i] = array1[counter1++];
                }
                else
                {
                    yes[i] = array2[counter2++];
                }
            }
        return yes;

    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        for (int i=0; i<(array.Length -1); i++)
            if (array[i]>array[i+1])
                return false;
        return true;
    }

    // TODO
    public static T[] MergeSortedArrays<T>(T[] array1, T[] array2) where T:IComparable<T>
    {
        T[] comb = new T[array1.Length + array2.Length];
        int counter1 = 0;
        int counter2 = 0;
        for (int i=0; i<(array1.Length+array2.Length); i++)
            {
                
                if (counter1 >= array1.Length)
                    comb[i] = array2[counter2++];

                else if (counter2 >= array2.Length)
                    comb[i] = array1[counter1++];

                else if (array1[counter1].CompareTo(array2[counter2]) <= 0)
                {
                    comb[i] = array1[counter1++];
                }
                else
                {
                    comb[i] = array2[counter2++];
                }
            }
        return comb;
    }
}


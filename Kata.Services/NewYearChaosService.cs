using System;

namespace Kata.Services
{
    public static class NewYorkChaosService
    {
        static int MinimumBribes(int[] q)
        {
            if(IsSorted(q))
            {
                return 0;
            }

            
        }

        static bool IsSorted(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i - 1] > arr[i])
                {
                    return false;
                }

                return true;
            }
        }
    }
}

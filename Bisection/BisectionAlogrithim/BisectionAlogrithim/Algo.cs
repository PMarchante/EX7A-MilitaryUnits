using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlogrithim
{
    class Algo
    {
        public int Finder(int x, int[] list)
        {
            int start = 0;
            int mid = list.Length / 2;
            int end = list.Length;
            Console.WriteLine($"The middle value is {list[mid]}");
            while(x != list[mid])
            {
                if(x> list[mid])
                {
                    Console.WriteLine($"The target {x} is higher than {list[mid]}");
                    start = mid;
                    mid = (start + end) / 2;
                    Console.WriteLine($"The middle value is {list[mid]}");
                }
                else if(x < list[mid])
                {
                    Console.WriteLine($"The target {x} is lower than {list[mid]}");
                    end = mid;
                    mid = (start + end) / 2;
                    Console.WriteLine($"The middle value is {list[mid]}");
                }
            }return mid;
        }
    }
}

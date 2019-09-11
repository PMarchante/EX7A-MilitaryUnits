using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlogrithim
{
    class Algo
    {
        public int Finder(int x, int[] list, Var vars)
        {
            
            vars.start = 0;
            vars.mid = list.Length / 2;
            vars.end = list.Length;
            Console.WriteLine($"The middle value is {list[vars.mid]}");
            while(x != list[vars.mid])
            {
                if(x> list[vars.mid])
                {
                    Console.WriteLine($"The target {x} is higher than {list[vars.mid]}");
                    vars.start = vars.mid;
                    vars.mid = (vars.start + vars.end) / 2;
                    Console.WriteLine($"The middle value is {list[vars.mid]}");
                }
                else if(x < list[vars.mid])
                {
                    Console.WriteLine($"The target {x} is lower than {list[vars.mid]}");
                    vars.end = vars.mid;
                    vars.mid = (vars.start + vars.end) / 2;
                    Console.WriteLine($"The middle value is {list[vars.mid]}");
                }
            }return vars.mid;
        }
    }
}

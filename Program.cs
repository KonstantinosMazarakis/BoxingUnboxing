using System;
using System.Collections.Generic;
namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new List<object>();
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");

            int sum = 0;
            for(int i = 0; i < box.Count;i++)
            {
                Console.WriteLine(box[i]);
                if(box[i] is int)
                {
                    sum = sum + (int)box[i];
                }
            }
                Console.WriteLine(sum);


        }
        
    }
}

















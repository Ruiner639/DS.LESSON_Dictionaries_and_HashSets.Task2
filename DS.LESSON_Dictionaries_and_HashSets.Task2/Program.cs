using System;

namespace DS.LESSON_Dictionaries_and_HashSets.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "4,2,2,5,2,3,2,3,1,5,2,6,6,6";
            string[] list = str.Split(",");
            int[] count = new int[15];
            int a = 0;
            while (a < list.Length)
            {
                int b = Convert.ToInt32(list[a]);
                count[b]++;
                a++;
            }
            a = 0;
            while (a < count.Length)
            {
                int b = Convert.ToInt32(count[a]);
                if (((b % 2) != 0))
                {
                    int i = 0;
                    while(i < list.Length)
                    {
                        if (Convert.ToInt32(list[i]) == a)
                        {
                            list[i] = null;
                        }
                        i++;
                    }
                }
                a++;
            }
            a = 0;
            while(a < list.Length)
            {
                Console.Write(list[a]);
                a++;
            }
        }
    }
}

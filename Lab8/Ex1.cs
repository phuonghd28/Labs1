using System.Collections.Generic;

namespace Lab8
{
    public class Ex1
    {
        public static int GreaterCount(List<int> list, double min)
                {
                    var count = 0;
                    foreach (var temperature in list)
                    {
                        if (temperature >= min)
                        {
                            count++;
                        }
                    }
        
                    return count;
                }
    }
}
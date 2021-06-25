using System.Collections;

namespace Lab8
{
    public class Ex2
    {
        public static int GreaterCount(IEnumerable enumerable, double min)
        {
            var count = 0;
            foreach (var temperature in enumerable)
            {
                if ((double) temperature >= min)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
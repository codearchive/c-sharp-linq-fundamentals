﻿using System.Collections.Generic;

namespace module_03.Linq
{
    public static class MyLinq
    {
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }

            return count;
        }
    }
}

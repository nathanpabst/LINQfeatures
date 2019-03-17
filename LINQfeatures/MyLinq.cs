﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQfeatures
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

using System;
using System.Collections.Generic;

namespace TestLinq
{
    internal static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            foreach (T item in source)
                action(item);
        }
    }
}

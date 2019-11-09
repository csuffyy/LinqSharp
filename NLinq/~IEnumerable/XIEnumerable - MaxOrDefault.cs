﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NLinq
{
    public static partial class XIEnumerable
    {
        public static int MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, int @default = default(int))
            => source.Any() ? source.Max(selector) : @default;
        public static long MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector, long @default = default(long))
            => source.Any() ? source.Max(selector) : @default;
        public static float MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector, float @default = default(float))
            => source.Any() ? source.Max(selector) : @default;
        public static double MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, double @default = default(double))
            => source.Any() ? source.Max(selector) : @default;
        public static decimal MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector, decimal @default = default(decimal))
            => source.Any() ? source.Max(selector) : @default;
        public static int? MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector, int? @default = default(int?))
            => source.Any() ? source.Max(selector) : @default;
        public static long? MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector, long? @default = default(long?))
            => source.Any() ? source.Max(selector) : @default;
        public static float? MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector, float? @default = default(float?))
            => source.Any() ? source.Max(selector) : @default;
        public static double? MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector, double? @default = default(double?))
            => source.Any() ? source.Max(selector) : @default;
        public static decimal? MaxOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector, decimal? @default = default(decimal?))
            => source.Any() ? source.Max(selector) : @default;
        public static TResult MaxOrDefault<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector, TResult @default = default(TResult))
            => source.Any() ? source.Max(selector) : @default;

        public static int MaxOrDefault(this IEnumerable<int> source, int @default = default(int))
            => source.Any() ? source.Max() : @default;
        public static long MaxOrDefault(this IEnumerable<long> source, long @default = default(long))
            => source.Any() ? source.Max() : @default;
        public static float MaxOrDefault(this IEnumerable<float> source, float @default = default(float))
            => source.Any() ? source.Max() : @default;
        public static double MaxOrDefault(this IEnumerable<double> source, double @default = default(double))
            => source.Any() ? source.Max() : @default;
        public static decimal MaxOrDefault(this IEnumerable<decimal> source, decimal @default = default(decimal))
            => source.Any() ? source.Max() : @default;
        public static TSource MaxOrDefault<TSource>(this IEnumerable<TSource> source, TSource @default = default(TSource))
            => source.Any() ? source.Max() : @default;
    }

}

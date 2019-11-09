﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace NLinq
{
    public static partial class XIQueryable
    {
        public static TResult MinOrDefault<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, TResult @default = default(TResult))
            => source.Any() ? source.Min(selector) : @default;

        public static TSource MinOrDefault<TSource>(this IQueryable<TSource> source, TSource @default = default(TSource))
            => source.Any() ? source.Min() : @default;

    }
}

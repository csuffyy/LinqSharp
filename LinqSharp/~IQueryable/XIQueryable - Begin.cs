﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinqSharp
{
    public static partial class XIQueryable
    {
        public static QueryableWhereExpressionBuilder<TSource> Begin<TSource>(this IQueryable<TSource> @this)
        {
            return new QueryableWhereExpressionBuilder<TSource>(@this);
        }

        public static QueryableWhereExpressionBuilder<TSource> Begin<TSource>(this IQueryable<TSource> @this, Expression<Func<TSource, bool>> predicate)
        {
            return new QueryableWhereExpressionBuilder<TSource>(@this, predicate);
        }

    }
}
﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinqSharp
{
    public class WhereHelperQ<TSource> : WhereHelper<TSource>
    {
        public IQueryable<TSource> Sources;

        public WhereHelperQ(IQueryable<TSource> sources)
        {
            Sources = sources;
        }

        public WhereExp<TSource> WhereMin<TResult>(Expression<Func<TSource, TResult>> selector)
        {
            if (Sources.Any())
            {
                var min = Sources.Min(selector);
                var whereExp = Expression.Lambda<Func<TSource, bool>>(
                    Expression.Equal(selector.Body, Expression.Constant(min, typeof(TResult))), selector.Parameters);
                return new WhereExp<TSource>(whereExp);
            }
            else return new WhereExp<TSource>(x => false);
        }
        public WhereExp<TSource> WhereMax<TResult>(Expression<Func<TSource, TResult>> selector)
        {
            if (Sources.Any())
            {
                var min = Sources.Max(selector);
                var whereExp = Expression.Lambda<Func<TSource, bool>>(
                    Expression.Equal(selector.Body, Expression.Constant(min, typeof(TResult))), selector.Parameters);
                return new WhereExp<TSource>(whereExp);
            }
            else return new WhereExp<TSource>(x => false);
        }

    }

}

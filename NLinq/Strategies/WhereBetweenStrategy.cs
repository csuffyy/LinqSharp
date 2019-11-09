﻿using NStandard;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace NLinq.Strategies
{
    public class WhereBetweenStrategy<TEntity> : IWhereStrategy<TEntity>
    {
        public Expression<Func<TEntity, bool>> StrategyExpression { get; }

        private static MethodInfo _Method_op_LessThanOrEqual = typeof(DateTime).GetMethodViaQualifiedName("Boolean op_LessThanOrEqual(System.DateTime, System.DateTime)");
        private static PropertyInfo _Property_DateTime_HasValue = typeof(DateTime?).GetProperty(nameof(Nullable<DateTime>.HasValue));
        private static PropertyInfo _Property_DateTime_Value = typeof(DateTime?).GetProperty(nameof(Nullable<DateTime>.Value));

        #region Return DateTime
        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime>> memberExp,
            Expression<Func<TEntity, DateTime>> startExp,
            Expression<Func<TEntity, DateTime>> endExp)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(
                    Expression.LessThanOrEqual(
                        startExp.Body.RebindParameter(startExp.Parameters[0], memberExp.Parameters[0]),
                        memberExp.Body,
                        false, _Method_op_LessThanOrEqual),
                    Expression.LessThanOrEqual(
                        memberExp.Body,
                        endExp.Body.RebindParameter(endExp.Parameters[0], memberExp.Parameters[0]),
                        false, _Method_op_LessThanOrEqual)), memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime>> memberExp,
            DateTime start,
            Expression<Func<TEntity, DateTime>> endExp)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(
                    Expression.LessThanOrEqual(
                        Expression.Constant(start),
                        memberExp.Body,
                        false, _Method_op_LessThanOrEqual),
                    Expression.LessThanOrEqual(
                        memberExp.Body,
                        endExp.Body.RebindParameter(endExp.Parameters[0], memberExp.Parameters[0]),
                        false, _Method_op_LessThanOrEqual)), memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime>> memberExp,
            Expression<Func<TEntity, DateTime>> startExp,
            DateTime end)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(
                    Expression.LessThanOrEqual(
                        startExp.Body.RebindParameter(startExp.Parameters[0], memberExp.Parameters[0]),
                        memberExp.Body,
                        false, _Method_op_LessThanOrEqual),
                    Expression.LessThanOrEqual(
                        memberExp.Body,
                        Expression.Constant(end),
                        false, _Method_op_LessThanOrEqual)), memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime>> memberExp,
            DateTime start,
            DateTime end)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(
                    Expression.LessThanOrEqual(
                        Expression.Constant(start),
                        memberExp.Body,
                        false, _Method_op_LessThanOrEqual),
                    Expression.LessThanOrEqual(
                        memberExp.Body,
                        Expression.Constant(end),
                        false, _Method_op_LessThanOrEqual)), memberExp.Parameters);
        }
        #endregion

        #region Return DateTime?
        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime?>> memberExp,
            Expression<Func<TEntity, DateTime>> startExp,
            Expression<Func<TEntity, DateTime>> endExp)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(
                    Expression.LessThanOrEqual(
                        startExp.Body.RebindParameter(startExp.Parameters[0], memberExp.Parameters[0]),
                        memberExp.Body,
                        false, _Method_op_LessThanOrEqual),
                    Expression.LessThanOrEqual(
                        memberExp.Body,
                        endExp.Body.RebindParameter(endExp.Parameters[0], memberExp.Parameters[0]),
                        false, _Method_op_LessThanOrEqual)), memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime?>> memberExp,
            DateTime start,
            Expression<Func<TEntity, DateTime>> endExp)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.Condition(
                    Expression.Property(memberExp.Body, _Property_DateTime_HasValue),
                    Expression.AndAlso(
                        Expression.LessThanOrEqual(
                            Expression.Constant(start),
                            memberExp.Body,
                            false, _Method_op_LessThanOrEqual),
                        Expression.LessThanOrEqual(
                            memberExp.Body,
                            endExp.Body.RebindParameter(endExp.Parameters[0], memberExp.Parameters[0]),
                            false, _Method_op_LessThanOrEqual)),
                    Expression.Constant(false)),
                    memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime?>> memberExp,
            Expression<Func<TEntity, DateTime>> startExp,
            DateTime end)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.Condition(
                    Expression.Property(memberExp.Body, _Property_DateTime_HasValue),
                    Expression.AndAlso(
                        Expression.LessThanOrEqual(
                            startExp.Body.RebindParameter(startExp.Parameters[0], memberExp.Parameters[0]),
                            memberExp.Body,
                            false, _Method_op_LessThanOrEqual),
                        Expression.LessThanOrEqual(
                            memberExp.Body,
                            Expression.Constant(end),
                            false, _Method_op_LessThanOrEqual)),
                    Expression.Constant(false)),
                    memberExp.Parameters);
        }

        public WhereBetweenStrategy(
            Expression<Func<TEntity, DateTime?>> memberExp,
            DateTime start,
            DateTime end)
        {
            StrategyExpression = Expression.Lambda<Func<TEntity, bool>>(
                Expression.Condition(
                    Expression.Property(memberExp.Body, _Property_DateTime_HasValue),
                    Expression.AndAlso(
                        Expression.LessThanOrEqual(
                            Expression.Constant(start),
                            Expression.Property(memberExp.Body, _Property_DateTime_Value),
                            false, _Method_op_LessThanOrEqual),
                        Expression.LessThanOrEqual(
                            Expression.Property(memberExp.Body, _Property_DateTime_Value),
                            Expression.Constant(end),
                            false, _Method_op_LessThanOrEqual)),
                    Expression.Constant(false)),
                    memberExp.Parameters);
        }
        #endregion

    }
}

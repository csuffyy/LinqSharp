﻿using Dawnx.Definition;
using NLinq.ProviderFunctions;
using System;
using System.Linq;

namespace NLinq
{
    public static partial class XIQueryable
    {
        /// <summary>
        /// Select the specified number of random record from a source set.
        /// <para>[Warning] Before calling this function, you need to open the provider functions.</para>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="this"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IQueryable<TSource> Random<TSource>(this IQueryable<TSource> @this, int count)
            where TSource : class
        {
            var providerName = GetProviderName(@this);

            switch (providerName)
            {
                case DatabaseProviderName.Cosmos: goto default;
                case DatabaseProviderName.Firebird: goto default;
                case DatabaseProviderName.IBM: goto default;
                case DatabaseProviderName.Jet: return @this.OrderBy(x => PJet.Rnd()).Take(count);
                case DatabaseProviderName.MyCat:
                case DatabaseProviderName.MySql: return @this.OrderBy(x => PMySql.Rand()).Take(count);
                case DatabaseProviderName.OpenEdge: goto default;
                case DatabaseProviderName.Oracle: return @this.OrderBy(x => POracle.Random()).Take(count);
                case DatabaseProviderName.PostgreSQL: return @this.OrderBy(x => PPostgreSQL.Random()).Take(count);
                case DatabaseProviderName.Sqlite: return @this.OrderBy(x => PSqlite.Random()).Take(count);
                case DatabaseProviderName.SqlServer:
                case DatabaseProviderName.SqlServerCompact35:
                case DatabaseProviderName.SqlServerCompact40: return @this.OrderBy(x => PSqlServer.Rand()).Take(count);

                case DatabaseProviderName.Unknown:
                default:
                    throw new NotSupportedException($"This method is not supported by the current provider({providerName}).");
            }
        }

    }

}

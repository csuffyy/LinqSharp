﻿using LinqSharp.EFCore.Data.Test;
using Northwnd;
using System;

namespace TestDatabaseCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sqlite = NorthwndContext.UseSqliteResource())
            using (var mysql = ApplicationDbContext.UseMySql())
            {
                sqlite.WriteTo(mysql);
            }

            Console.WriteLine("Complete");
        }
    }
}

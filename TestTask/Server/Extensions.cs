using System;
using Microsoft.EntityFrameworkCore;

namespace TestTask.Server
{
    public static class Extensions
    {
        public static void Update<TEntity>(this DbSet<TEntity> set, int id, Action<TEntity> func) where TEntity : class
        {

        }
    }
}
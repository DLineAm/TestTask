using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    public class Cache
    {
        /// <summary>
        /// Текущая сессия приложения
        /// </summary>
        public static ISession Session { get; set; }
    }
}
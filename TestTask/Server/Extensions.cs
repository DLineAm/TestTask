using TestTask.Shared;

namespace TestTask.Server
{
    public static class Extensions
    {
        /// <summary>
        /// Получает значение универсального свойства TProp с типом T
        /// </summary>
        public static TProp GetGenericProperty<T, TProp>(this object instance) where T : IIdentity, new() where TProp : class
        {
            var type = typeof(T);
            var properties = instance.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propType = property.PropertyType;
                if (!propType.IsGenericType || propType != typeof(TProp))
                    continue;

                var genericArgument = propType.GetGenericArguments()[0];
                if (genericArgument == type)
                    return property.GetValue(instance) as TProp;
            }

            return null;
        }
    }
}
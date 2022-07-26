using System.Collections.Generic;
using System.Linq;
using TestTask.Shared;

namespace TestTask.Client.Utils
{
    public static class TreeHelper
    {
        /// <summary>
        /// Проверка, создается ли цикл из ключей родительских подразделений списка подразделений
        /// </summary>
        /// <param name="divisions">Список подразделений</param>
        /// <returns>True, если цикл создается. False, если нет</returns>
        public static bool IsLoop(IEnumerable<Division> divisions)
        {
            foreach (var division in divisions)
            {
                if (divisions.Where(d => d.Id != division.Id).All(d => d.Id != division.DivisionId))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
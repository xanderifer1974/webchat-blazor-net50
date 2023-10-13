using System;
using System.Collections.Generic;
using System.Linq;

namespace webchatBlazor.Util
{
    public static class Util
    {
        /*
         * Como utilizar a classe genérica : int nextId = IdGenerator.GetNextId(objectList, x => x.ID);
         * */
        public static int ObtemProximoId<T>(List<T> objectList, Func<T, int> idSelector)
        {
            if (objectList == null || objectList.Count == 0)
            {
                return 1; // Retorna 1 se a lista estiver vazia.
            }

            int lastId = objectList.Max(idSelector);
            return lastId + 1;
        }
    }
    
}

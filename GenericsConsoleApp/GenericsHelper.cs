using System.Collections.Generic;

namespace GenericsConsoleApp
{
    public class GenericsHelper<T> where T : class, IDefectCheck
    {

        private List<T> nonDefectedItems { get; set; } = new List<T>();
        private List<T> defectedItems { get; set; } = new List<T>();
        public void CheckItemAndAdd(T item)
        {
            if (!item.hasDefect)
            {

                nonDefectedItems.Add(item);
             
            }
            else
            {
                defectedItems.Add(item);
                
            }
        }
   
        public List<T> GetDefectedItems()
        {
            return defectedItems;
        }
        public List<T> GetNonDefectedItems()
        {
            return nonDefectedItems;
        }
        
    }
}

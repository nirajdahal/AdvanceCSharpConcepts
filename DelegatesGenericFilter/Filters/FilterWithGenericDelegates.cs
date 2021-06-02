using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesGenericFilter.Filters
{
    public static class FilterWithGenericDelegates
    {
       
          
            public static List<T> FilterTtems<T>(this List<T> items, Func<T, bool> applyCondition)
            {
                var filtereditems = new List<T>();
                foreach (var item in items)
                {
                    if (applyCondition(item))
                    {
                        filtereditems.Add(item);
                    }
                }
                return filtereditems;
            }
        }
    }


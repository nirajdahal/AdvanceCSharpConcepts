using GenericCsvApp.Events;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GenericCsvApp.Helper
{
    public class FileHandlerHelper<T> where T: new()
    {
        public static PropertyInfo[] GetPropertiesOfGenericClass()
        {
            T entry = new T();
            PropertyInfo[] properties = entry.GetType().GetProperties();

            return properties;
        }
   
    
        public static void AddPropertyToRows(PropertyInfo[]  properties, List<string> rows)
        {
            var row = "";

            foreach (var col in properties)
            {
                row += "," + col.Name;
            }

            row = row.Substring(1);

            rows.Add(row);
        }

        public static void AddValueOfProperty(PropertyInfo[] properties, List<string> rows, List<T> items)
        {
            foreach (var item in items)
            {
                var row = "";

                foreach (var col in properties)
                {
                    row += "," + col.GetValue(item, null);
                }

                BadWordsEvents<T> checker = new BadWordsEvents<T>();
                var hasBadWord = checker.BadWordDetector(row, item);
                if (!hasBadWord)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
                
            }
        }

        
    }
}

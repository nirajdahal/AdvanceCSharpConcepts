using GenericCsvApp.Contracts;
using GenericCsvApp.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GenericCsvApp.Helper
{
    public class CsvFileHandler<T> : IDataAccess<T> where T:class, new()
    {
        public delegate void ReturnValueDelegate(string s);
        List<string> rows = new List<string>();
        public void CreateFile(List<T> items, string path)
        {

            var properties =  GetPropertiesOfGenericClass();
            GetPropertiesToAdd(properties, rows, AddPropertiesToRow);
            GetValuesToAdd(properties, rows, items, AddValuedToRow);
            SaveToFile(path, rows);


        }


        public static void SaveToFile(string path, List<string> rows)
        {
            File.WriteAllLines(path, rows);
        }

        private  void AddValuedToRow(string row)
        {

            BadWordsEvents<T> checker = new BadWordsEvents<T>();
            checker.BadWordDetected += BadWordsEvents<T>.Checker_BadWordDetected;
            var hasBadWord = checker.BadWordDetector(row);


            if (!hasBadWord)
            {
                row = row.Substring(1);
                rows.Add(row);
            }
        }

        private void AddPropertiesToRow(string row)
        {
            rows.Add(row);
        }

        private static PropertyInfo[] GetPropertiesOfGenericClass()
        {
            T entry = new T();
            PropertyInfo[] properties = entry.GetType().GetProperties();

            return properties;
        }


        private static void GetPropertiesToAdd(PropertyInfo[] properties, List<string> rows, ReturnValueDelegate returnValue)
        {
            var row = "";

            foreach (var col in properties)
            {
                row += "," + col.Name;
            }

            row = row.Substring(1);

            returnValue(row);
        }

        public static void GetValuesToAdd(PropertyInfo[] properties, List<string> rows, List<T> items, ReturnValueDelegate returnValue)
        {


            foreach (var item in items)
            {
                var row = "";

                foreach (var col in properties)
                {

                    row += "," + col.GetValue(item, null);

                }
                returnValue(row);
            }
        }

    }
}

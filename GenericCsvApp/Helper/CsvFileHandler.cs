using GenericCsvApp.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericCsvApp.Helper
{
    public class CsvFileHandler<T> : ICsvHelper<T> where T:class, new()
    {
        List<string> rows = new List<string>();
        public void CreateFile(List<T> items)
        {

            var properties =  FileHandlerHelper<T>.GetPropertiesOfGenericClass();
            FileHandlerHelper<T>.AddPropertyToRows(properties, rows);
            FileHandlerHelper<T>.AddValueOfProperty(properties, rows, items);

            File.WriteAllLines("C:/Users/tulshi/source/repos/AdvanceCSharpConcepts/GenericCsvApp/writefile.csv", rows);
        }

    }
}

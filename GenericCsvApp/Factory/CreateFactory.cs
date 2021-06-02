using GenericCsvApp.Contracts;
using GenericCsvApp.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCsvApp.Factory
{
    public static class CreateFactory
    {
        public static IDataAccess<T> Create<T>() where T:class, new()
        {
            var csv = new CsvFileHandler<T>();
            return csv;
        }
    }
}

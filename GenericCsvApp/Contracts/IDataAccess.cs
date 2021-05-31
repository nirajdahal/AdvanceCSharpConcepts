using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCsvApp.Contracts
{
    public interface IDataAccess<T>
    {
         void CreateFile(List<T> items, string path);

    }
}

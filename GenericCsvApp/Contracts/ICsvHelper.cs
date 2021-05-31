using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCsvApp.Contracts
{
    public interface ICsvHelper<T>
    {
         void CreateFile(List<T> items);

    }
}

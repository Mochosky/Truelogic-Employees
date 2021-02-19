using System.Collections.Generic;

namespace Infrastructure
{
    public interface IEmployeeBaseProvider
    {
        IEnumerable<IEmployeeBase> GetEmployeeBaseList(int? id = null);
    }
}

using System.Collections.Generic;

namespace Infrastructure
{
    public interface IEmployeeProvider
    {
        IEnumerable<IEmployee> GetEmployeeList(int? id = null);

    }
}

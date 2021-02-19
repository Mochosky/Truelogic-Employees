namespace Infrastructure
{
    public interface IEmployeeBase
    {
        int id { get; set; }
        string name { get; set; }
        string contractType { get; set; }
        int roleId { get; set; }
        string roleName { get; set; }
        string roleDescription { get; set; }
        decimal hourlySalary { get; set; }
        decimal monthlySalary { get; set; }
    }
}

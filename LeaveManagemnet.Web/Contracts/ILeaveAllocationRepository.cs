using LeaveManagemnet.Web.Data;
using LeaveManagemnet.Web.Models;

namespace LeaveManagemnet.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveTypeAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);

    }
}

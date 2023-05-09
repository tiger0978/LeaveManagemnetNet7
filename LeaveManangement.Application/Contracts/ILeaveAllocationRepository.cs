﻿using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveTypeAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocations(string employeeId,int leaveTypeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);


    }
}

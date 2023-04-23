using LeaveManagemnet.Web.Data;
using LeaveManagemnet.Web.Models;

namespace LeaveManagemnet.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task ChangeApproveStatus(int leaveRequestId, bool approved);

        Task CancelLeaveRequest(int leaveRequestId);
    }
}

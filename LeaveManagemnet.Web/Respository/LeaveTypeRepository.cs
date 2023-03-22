using LeaveManagemnet.Web.Contracts;
using LeaveManagemnet.Web.Data;

namespace LeaveManagemnet.Web.Respository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

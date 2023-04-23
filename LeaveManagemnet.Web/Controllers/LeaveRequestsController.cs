using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagemnet.Web.Data;
using LeaveManagemnet.Web.Models;
using AutoMapper;
using LeaveManagemnet.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagemnet.Web.Constants;
using LeaveManagemnet.Web.Respository;

namespace LeaveManagemnet.Web.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILeaveRequestRepository leaveRequestRepository;

        public LeaveRequestsController(ApplicationDbContext context, ILeaveRequestRepository leaveRequestRepository)
        {
            _context = context;
            this.leaveRequestRepository = leaveRequestRepository;
        }

        // GET: LeaveRequests/Create
        public IActionResult Create()
        {
            var model= new LeaveRequestCreateVM
            {
                LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name")
            };
            return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await leaveRequestRepository.CreateLeaveRequest(model);
                    return RedirectToAction(nameof(MyLeave));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occured, Please Try Again Later");
            }

            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
            return View(model);
        }

        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestRepository.GetAdminLeaveRequestList();
            return View(model);
        }

        public async Task<IActionResult> MyLeave()
        {
            var model = await leaveRequestRepository.GetMyLeaveDetails();
            return View(model);
        }

        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var model = await leaveRequestRepository.GetLeaveRequestAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRequest(int id, bool approved)
        {
            try 
            {
                await leaveRequestRepository.ChangeApproveStatus(id, approved);
            }
            catch(Exception ex)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Cancel(int id)
        {
            try
            {
                await leaveRequestRepository.CancelLeaveRequest(id);
            }
            catch (Exception ex) 
            {
                throw;
            }
            return RedirectToAction(nameof(MyLeave));
        }
    }
}

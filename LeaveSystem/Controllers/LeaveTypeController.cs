using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveSystem.Data;
using LeaveSystem.Interface;
using LeaveSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaveSystem.Controllers
{
    public class LeaveTypeController : Controller
    {

        private readonly ILeaveTypeRepo _repo;
        private readonly IMapper _mapper;

        public LeaveTypeController(ILeaveTypeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: LeaveType
        public ActionResult Index()
        {
            var leaveTypes = _repo.FindAll().ToList();
            var model = _mapper.Map<List<LeaveType>, List<LeaveTypeVM>>(leaveTypes);
            return View(model);
        }

        // GET: LeaveType/Details/5
        public ActionResult Details(int id)
        {
            var model = _repo.GetByID(id);
            var leavetype = _mapper.Map<LeaveTypeVM>(model);
            return View(leavetype);
        }

        // GET: LeaveType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeaveTypeVM model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                var leavetype=_mapper.Map<LeaveType>(model);
                leavetype.DateCreated = DateTime.Now;
                var isSuccess = _repo.Create(leavetype);
                if(!isSuccess)
                {
                    ModelState.AddModelError("", "somethig went wrong...");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveType/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _repo.GetByID(id);
            var leavetype = _mapper.Map<LeaveTypeVM>(model);
            return View(leavetype);
        }

        // POST: LeaveType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LeaveTypeVM model)
        {
            try
            {
                var leavetype = _mapper.Map<LeaveType>(model);
                leavetype.DateCreated = DateTime.Now;
                var isSuccess = _repo.Update(leavetype);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "somethig went wrong...");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "somethig went wrong...");
                return View(model);
            }
        }

        // GET: LeaveType/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _repo.GetByID(id);
            var leavetype = _mapper.Map<LeaveTypeVM>(model);
            return View(leavetype);
        }

        // POST: LeaveType/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(LeaveTypeVM model)
        {
            try
            {
                var leavetype = _mapper.Map<LeaveType>(model);
                leavetype.DateCreated = DateTime.Now;
                var isSuccess = _repo.Delete(leavetype);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "somethig went wrong...");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
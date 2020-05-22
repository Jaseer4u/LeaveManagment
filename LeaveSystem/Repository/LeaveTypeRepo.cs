using LeaveSystem.Data;
using LeaveSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeaveSystem.Repository
{
    public class LeaveTypeRepo : ILeaveType
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepo(ApplicationDbContext db)
        {
            db = this._db;
        }

        public bool Create(LeaveType entity)
        {
            _db.LeaveType.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveType.Remove(entity);
            return Save();
        }

        public IList<LeaveType> FindAll()
        {
            return _db.LeaveType.ToList();
        }

        public LeaveType GetByID(int ID)
        {
            return _db.LeaveType.Find(ID);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveType.Update(entity);
            return Save();
        }
    }
}

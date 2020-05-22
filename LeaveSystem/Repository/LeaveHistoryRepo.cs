using LeaveSystem.Data;
using LeaveSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Repository
{
    public class LeaveHistoryRepo : ILeaveHistory
    {

        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepo(ApplicationDbContext db)
        {
            db = this._db;
        }
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistory.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistory.Remove(entity);
            return Save();
        }

        public IList<LeaveHistory> FindAll()
        {
            return _db.LeaveHistory.ToList();
        }

        public LeaveHistory GetByID(int ID)
        {
            return _db.LeaveHistory.Find(ID);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistory.Update(entity);
            return Save();
        }
    }
}

using LeaveSystem.Data;
using LeaveSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Repository
{
    public class LeaveAllocationsRepo : ILeaveAllocations
    {

        private readonly ApplicationDbContext _db;

        public LeaveAllocationsRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocations entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocations entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocations> FindAll()
        {
            return _db.LeaveAllocations.ToList();
        }

        public LeaveAllocations GetByID(int ID)
        {
            return _db.LeaveAllocations.Find(ID);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocations entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}

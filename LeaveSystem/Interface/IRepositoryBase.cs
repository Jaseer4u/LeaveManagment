﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Interface
{
    public interface IRepositoryBase<T> where T: class
    {
        ICollection<T> FindAll();
        T GetByID(int ID);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}

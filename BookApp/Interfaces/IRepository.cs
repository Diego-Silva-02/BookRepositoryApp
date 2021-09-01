﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Atualize(int id, T entity);
        int NextId();
    }
}

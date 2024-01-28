﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories.unitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
        void Clear();
    }
}

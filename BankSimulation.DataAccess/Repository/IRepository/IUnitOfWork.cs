﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IUserRepository _userRepository { get; }

        void Save();
    }
}

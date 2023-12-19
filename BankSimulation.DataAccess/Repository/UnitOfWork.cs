using BankSimulation.DataAccess.Data;
using BankSimulation.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }
        public IUserRepository _userRepository { get; private set; }

        public void Save()
        {
         _db.SaveChanges();
        }
    }
}

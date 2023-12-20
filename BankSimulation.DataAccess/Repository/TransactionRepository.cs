using BankSimulation.DataAccess.Data;
using BankSimulation.DataAccess.Repository.IRepository;
using BankSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.DataAccess.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        private readonly ApplicationDbContext _transactionRepository;
        public TransactionRepository(ApplicationDbContext db):base(db) 
        {
            _transactionRepository = db;
        }
        public void Save()
        {
            _transactionRepository.SaveChanges();
        }

        public void Update(Transaction transaction)
        {
            _transactionRepository.Update(transaction);
        }
    }
}

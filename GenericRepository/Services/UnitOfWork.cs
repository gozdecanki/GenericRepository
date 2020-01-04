using GenericRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Services
{
    public class UnitOfWork:Interfaces.IUnitOfWork
    {
        private readonly DataContext _dataContex;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContex = dataContext;

            UserRepository = new Services.UserRepository(_dataContex);

        }

        public int Complete()
        {
          return  _dataContex.SaveChanges();
        }

        public void Dispose()
        {
            _dataContex.Dispose();
        }
        public IUserRepository UserRepository { get; set; }
    }
}

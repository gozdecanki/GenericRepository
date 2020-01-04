using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Services
{
    public class UserRepository:Repository<User>,Interfaces.IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}

using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Interfaces
{
    public interface IUserRepository:Interfaces.IRepository<User>
    {
    }
}

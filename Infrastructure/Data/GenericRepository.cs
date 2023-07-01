using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        

        Task<T> IGenericRepository<T>.GetByIdAsyncy(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<T>> IGenericRepository<T>.ListAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
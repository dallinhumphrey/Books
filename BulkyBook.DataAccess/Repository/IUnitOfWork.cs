using System;
using System.Collections.Generic;
using System.Text;
using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public interface IUnitOfWork : IDisposable
    {

        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}

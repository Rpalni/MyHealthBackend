using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHealth.DAL.Interface.UnitOfWork
{
    public interface IUnitOfWork
    {
        IImageRepository ImageRepo { get;  }
        Task<int> CompleteAsync();
        int Complete();
    }
}

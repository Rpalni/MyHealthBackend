using MyHealth.DomainModel;
using MyHealth.DAL.Interface;
using MyHealth.DAL.Interface.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyHealth.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext dbContext;
        public UnitOfWork(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private IImageRepository _ImageRepo;

        public IImageRepository ImageRepo
        {
            get
            {
                if (this._ImageRepo == null)
                {
                    this._ImageRepo = new ImageRepository(dbContext);
                }
                return this._ImageRepo;
            }
        }
        
        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
        public int Complete()
        {
            return dbContext.SaveChanges();
        }
        public void Dispose() => dbContext.Dispose();

    }
}

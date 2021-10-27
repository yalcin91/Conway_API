using Conway.Core.Service;
using Conway.Core.UnitOfWorks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Service.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWorks _unitOfWork;
        private readonly IService<TEntity> _service;
        public Service(IUnitOfWorks unitOfWork, IService<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _service = repository;
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _service.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await _service.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _service.Remove(entity);
            _unitOfWork.Commit();
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _service.SingleOrDefault(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            TEntity updateEntity = _service.Update(entity);
            _unitOfWork.Commit();
            return updateEntity;
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _service.Where(predicate);
        }
    }
}

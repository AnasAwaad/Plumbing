﻿using CoreLayer.BaseEntities;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Abstract;
public interface IGenericRepository<T> where T : class,IBaseEntity,new()
{
	Task AddEntityAsync(T entity);
	void UpdateEntity(T entity);
	void DeleteEntity(T entity);
	IQueryable<T> GetAllEntityList();
	IQueryable<T> Where(Expression<Func<T, bool>> predicate);
	Task<T> FindByIdAsync(int id);
}

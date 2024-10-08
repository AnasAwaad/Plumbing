﻿using CoreLayer.BaseEntities;
using RepositoryLayer.Repositories.Abstract;

namespace RepositoryLayer.UnitOfWorks.Abstract;
public interface IUnitOfWork
{
	void Commit();
	Task CommitAsync();
	IGenericRepository<T> GetGenericRepository<T>() where T : class, IBaseEntity,new();
	ValueTask DisposeAsync();
}

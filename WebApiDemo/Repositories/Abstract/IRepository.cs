﻿namespace WebApiDemo.Repositories.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);   
    }
}

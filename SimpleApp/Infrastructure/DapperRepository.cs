using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using SimpleApp.Core.Interfaces;
using SimpleApp.Core.Models;
using System.Collections.Generic;

namespace SimpleApp.Infrastructure
{
    public class DapperRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly MySqlConnection _connection;

        public DapperRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public T GetById(int id)
        {
            return _connection.Get<T>(id);
        }

        public IEnumerable<T> List()
        {
            return _connection.GetAll<T>();
        }

        public void Insert(T entity)
        {
            _connection.Insert(entity);
        }

        public void Update(T entity)
        {
            _connection.Update(entity);
        }

        public void Delete(T entity)
        {
            _connection.Delete(entity);
        }
    }
}

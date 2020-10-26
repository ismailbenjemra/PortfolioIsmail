using Core.Interfaces;
using InfraStracture.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStracture.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        //permet de faire le Save la persistance
        private readonly DataContext _context;
        private IGenericRepository<T> _entity;
        public UnitOfWork(DataContext context)
        {
            _context = context;

        }
        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

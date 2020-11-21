using CustomerOrder.Core.Domain;
using CustomerOrder.Core.Interface;
using CustomerOrder.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder.Service.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly CustomerOrderContext _context;

        public UnitOfWork(CustomerOrderContext context)
        {
            _context = context;
        }
        public IRepository<Customer> CustomerRepository => new Repository<Customer>(_context);
        public IRepository<Address> AddressRepository => new Repository<Address>(_context);
        public IRepository<Order> OrderRepository => new Repository<Order>(_context);


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
    }

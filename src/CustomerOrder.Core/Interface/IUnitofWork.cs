using CustomerOrder.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder.Core.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Address>AddressRepository { get; }
        IRepository<Order> OrderRepository { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}

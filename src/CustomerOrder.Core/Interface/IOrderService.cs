using CustomerOrder.Core.Utility;
using CustomerOrder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder.Core.Interface
{
    public interface IOrderService
    {
        Task<ResponseModel<CustomerOrderDTO>> Create(CustomerOrderDTO customerOrderDTO);
    }
}

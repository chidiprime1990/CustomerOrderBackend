using CustomerOrder.Core.Utility;
using CustomerOrder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder.Core.Interface
{
    public interface ICustomerService
    {
     Task<ResponseModel<CustomerDTO>> Create(CustomerDTO customerDTO);
     ResponseModel<List<CustomerDTO>> Search(string name);
     Task<ResponseModel<CustomerDTO>> Update(CustomerDTO customerDTO);
     Task<ResponseModel<bool>> Delete(int customerID);
    }
}

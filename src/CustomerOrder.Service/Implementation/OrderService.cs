using CustomerOrder.Core.Domain;
using CustomerOrder.Core.Interface;
using CustomerOrder.Core.Utility;
using CustomerOrder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<ResponseModel<CustomerOrderDTO>> Create(CustomerOrderDTO customerOrderDTO)
        {
            try
            {
                foreach (var orderObj in customerOrderDTO.Orders)
                {
                    //Map customer orders view model to orders entity model
                    var order = new Order
                    {
                        CustomerID=customerOrderDTO.CustomerId,
                        Amount=Convert.ToDecimal(orderObj.Amount),
                        OrderDate=Convert.ToDateTime(orderObj.OrderDate)          
                    };
                    _unitOfWork.OrderRepository.Add(order);
                }
                //commiting the transaction 
                await _unitOfWork.CompleteAsync();
                return new ResponseModel<CustomerOrderDTO>
                { ResponseCode = Constants.OK, ResponseMessage = Constants.OK, ResponseData = customerOrderDTO };

            }
            catch (Exception)
            {

                return new ResponseModel<CustomerOrderDTO>
                { ResponseCode = Constants.Server_Error, ResponseMessage = Constants.Server_Error, ResponseData = null };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Extensions;
using AutoWrapper.Wrappers;
using CustomerOrder.Core.Interface;
using CustomerOrder.Core.Utility;
using CustomerOrder.Core.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrder.API.Controllers
{
    [Produces("application/json")]
    [EnableCors("AllowAllOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        protected readonly ICustomerService _customerservice;
        protected readonly IOrderService _orderservice;

        public CustomerController(ICustomerService customerservice, IOrderService orderservice)
        {
            _customerservice = customerservice;
            _orderservice = orderservice;
        }
        //Post Customer
        [HttpPost]
        public async Task<ApiResponse> Post([FromBody]CustomerDTO customerDTO)
        {
            ResponseModel<CustomerDTO> result;
            if (!ModelState.IsValid)
            {
                throw new ApiException(ModelState.AllErrors());
            }
            result = await _customerservice.Create(customerDTO);
            return ApiResponseFactory<CustomerDTO>.GetResponse(result);
        }
        //Get Customer
        [HttpGet("{name}")]
        public ApiResponse Get(string name)
        {
            ResponseModel<List<CustomerDTO>> result;
            result = _customerservice.Search(name);
            return ApiResponseFactory<List<CustomerDTO>>.GetResponse(result);
        }
        //Get Customer
        [HttpDelete("{id}")]
        public async Task<ApiResponse> Delete(int id)
        {
            ResponseModel<bool> result;
            result = await _customerservice.Delete(id);
            return ApiResponseFactory<bool>.GetResponse(result);
        }
        //Get Customer
        [HttpPut]
        public async Task<ApiResponse> Update([FromBody]CustomerDTO customerDTO)
        {
            ResponseModel<CustomerDTO> result;
            result = await _customerservice.Update(customerDTO);
            return ApiResponseFactory<CustomerDTO>.GetResponse(result);
        }
        //Post Orders
        [HttpPost("Order")]
        public async Task<ApiResponse> PostOrder([FromBody]CustomerOrderDTO customerOrderDTO)
        {
            ResponseModel<CustomerOrderDTO> result;
            if (!ModelState.IsValid)
            {
                throw new ApiException(ModelState.AllErrors());
            }
            result = await _orderservice.Create(customerOrderDTO);
            return ApiResponseFactory<CustomerOrderDTO>.GetResponse(result);
        }
    }
}
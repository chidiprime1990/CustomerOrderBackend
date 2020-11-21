using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Core.Utility
{
    public class ResponseModel<T>
    {
        public T ResponseData { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }

    }
}

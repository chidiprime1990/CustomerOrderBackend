using AutoWrapper.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Core.Utility
{
    public static class ApiResponseFactory<T>
    {
        public static ApiResponse GetResponse(ResponseModel<T> responseModel)
        {

            if (responseModel.ResponseData == null || responseModel.ResponseData.Equals(false))
            {

                if (responseModel.ResponseCode == Constants.BAD_REQUEST)
                    throw new ApiException(responseModel.ResponseMessage, 400);
                if (responseModel.ResponseCode == Constants.NOT_FOUND)
                    throw new ApiException(responseModel.ResponseMessage, 404);
                if (responseModel.ResponseCode == Constants.UNAUTHORIZED)
                    throw new ApiException(responseModel.ResponseMessage, 401);
                throw new ApiException(responseModel.ResponseMessage, 500);
            }
            return new ApiResponse(responseModel.ResponseMessage, responseModel.ResponseData, 200);
        }
    }
}

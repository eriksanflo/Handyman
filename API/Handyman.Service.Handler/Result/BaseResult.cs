using Handyman.Service.Handler.Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Handyman.Service.Handler.Result
{
    public class BaseResult
    {
        public bool Success { get; private set; }
        public HttpBaseResponse HttpResponse { get; private set; }

        internal void SetSuccess() => Success = true;
        internal void BuildBadRequest(string message)
        {
            Success = false;
            HttpResponse = new HttpBaseResponse
            {
                Title = HttpStatusCode.BadRequest.ToString(),
                Status = (int)HttpStatusCode.BadRequest,
                ErrorDetails = new ErrorDetail
                {
                    Detail = message,
                }
            };
        }
    }
}

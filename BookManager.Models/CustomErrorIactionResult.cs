using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class CustomError : IActionResult
    {
        private readonly HttpStatusCode _status;
        private readonly string _errorMessage;

        public CustomError(HttpStatusCode status, string errorMessage)
        {
            _status = status;
            _errorMessage = errorMessage;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(new
            {
                errorMessage = _errorMessage
            })
            {
                StatusCode = (int)_status,
            };

            context.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = _errorMessage;

            await objectResult.ExecuteResultAsync(context);
        }
    }
}

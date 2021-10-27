using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Conway.Core.Model;
using Conway.Core.Service;

using Conway.RESTService.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conway.RESTService.Filters
{
    public class NotFoundFilterProduct : ActionFilterAttribute
    {
        private readonly IService<Product> _productService;
        public NotFoundFilterProduct(IService<Product> productService)
        {
            _productService = productService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);
            if (product != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id {id} niet gevonden in database");
                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}

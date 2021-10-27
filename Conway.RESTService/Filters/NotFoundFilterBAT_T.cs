using Conway.Core.Model;
using Conway.Core.Service;
using Conway.RESTService.DTOs;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conway.RESTService.Filters
{
    public class NotFoundFilterBAT_T : ActionFilterAttribute
    {
        private readonly IService<BAT_Tabac> _BAT_TabacService;
        public NotFoundFilterBAT_T(IService<BAT_Tabac> BAT_TabacService)
        {
            _BAT_TabacService = BAT_TabacService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var BAT_Tabac = await _BAT_TabacService.GetByIdAsync(id);
            if (BAT_Tabac != null)
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

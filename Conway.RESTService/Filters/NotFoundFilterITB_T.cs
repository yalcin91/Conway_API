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
    public class NotFoundFilterITB_T : ActionFilterAttribute
    {
        private readonly IService<ITB_Tabac> _ITB_TabacService;
        public NotFoundFilterITB_T(IService<ITB_Tabac> ITB_TabacService)
        {
            _ITB_TabacService = ITB_TabacService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var ITB_Tabac = await _ITB_TabacService.GetByIdAsync(id);
            if (ITB_Tabac != null)
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

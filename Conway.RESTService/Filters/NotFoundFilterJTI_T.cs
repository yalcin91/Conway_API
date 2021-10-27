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
    public class NotFoundFilterJTI_T : ActionFilterAttribute
    {
        private readonly IService<JTI_Tabac> _JTI_TabacService;
        public NotFoundFilterJTI_T(IService<JTI_Tabac> JTI_TabacService)
        {
            _JTI_TabacService = JTI_TabacService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var JTI_Tabac = await _JTI_TabacService.GetByIdAsync(id);
            if (JTI_Tabac != null)
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

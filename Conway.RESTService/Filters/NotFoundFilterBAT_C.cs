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
    public class NotFoundFilterBAT_C : ActionFilterAttribute
    {
        private readonly IService<BAT_Cigarette> _BAT_CigaretteService;
        public NotFoundFilterBAT_C(IService<BAT_Cigarette> BAT_CigaretteService)
        {
            _BAT_CigaretteService = BAT_CigaretteService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var BAT_Cigarette = await _BAT_CigaretteService.GetByIdAsync(id);
            if (BAT_Cigarette != null)
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

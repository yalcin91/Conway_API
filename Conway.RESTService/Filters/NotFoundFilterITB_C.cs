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
    public class NotFoundFilterITB_C : ActionFilterAttribute
    {
        private readonly IService<ITB_Cigarette> _ITB_CigaretteService;
        public NotFoundFilterITB_C(IService<ITB_Cigarette> ITB_CigaretteService)
        {
            _ITB_CigaretteService = ITB_CigaretteService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var ITB_Cigarette = await _ITB_CigaretteService.GetByIdAsync(id);
            if (ITB_Cigarette != null)
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

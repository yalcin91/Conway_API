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
    public class NotFoundFilterJTI_C : ActionFilterAttribute
    {
        private readonly IService<JTI_Cigarette> _JTI_CigaretteService;
        public NotFoundFilterJTI_C(IService<JTI_Cigarette> JTI_CigaretteService)
        {
            _JTI_CigaretteService = JTI_CigaretteService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var JTI_Cigarette = await _JTI_CigaretteService.GetByIdAsync(id);
            if (JTI_Cigarette != null)
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

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
    public class NotFoundFilterPMI_C : ActionFilterAttribute
    {
        private readonly IService<PMI_Cigarette> _PMI_CigaretteService;
        public NotFoundFilterPMI_C(IService<PMI_Cigarette> PMI_CigaretteService)
        {
            _PMI_CigaretteService = PMI_CigaretteService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long id = (long)context.ActionArguments.Values.FirstOrDefault();
            var PMI_Cigarette = await _PMI_CigaretteService.GetByIdAsync(id);
            if (PMI_Cigarette != null)
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

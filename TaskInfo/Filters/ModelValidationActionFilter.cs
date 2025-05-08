using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TaskInfo.Filters
{
    public class ModelValidationActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                // Return a BadRequest with validation errors
                context.Result = new BadRequestObjectResult(context.ModelState);
                return;
            }
            await next();
        }
    }
}

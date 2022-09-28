using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SoalNo4.Contracts;
using SoalNo4.Entities;

namespace SoalNo4.ActionFilters
{
    public class ValidateEntityExistsAttribute<T> : IActionFilter where T : class, IEntity
    {
        private readonly ApplicationDbContext dbContext;

        public ValidateEntityExistsAttribute(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = Guid.Empty;

            if (context.ActionArguments.ContainsKey("id"))
            {
                id = (Guid)context.ActionArguments["id"];
            }
            else
            {
                context.Result = new BadRequestObjectResult("Bad id parameter");
                return;
            }

            var entity = dbContext.Set<T>().SingleOrDefault(x => x.Id.Equals(id));
            if (entity == null)
            {
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
            }
        }
    }
}

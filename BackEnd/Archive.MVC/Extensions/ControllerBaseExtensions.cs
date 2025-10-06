using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Archive.MVC.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static async Task<bool> IsValidAsync<T>(this ControllerBase controller, T model)
        {
            var validator = controller.HttpContext.RequestServices.GetRequiredService<IValidator<T>>();
            var result = await validator.ValidateAsync(model);

            if (result.IsValid)
            {
                return true;
            }

            foreach (var error in result.Errors)
            {
                controller.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }

            return false;
        }
    }
} 
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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

            string? prefix = null;

            var modelMetadataProvider = controller.HttpContext.RequestServices.GetService<IModelMetadataProvider>();
            if (modelMetadataProvider != null)
            {
                var modelMetadata = modelMetadataProvider.GetMetadataForType(typeof(T));
                var modelName = modelMetadata.ModelType.Name;
                prefix = modelName + ".";
            }


            foreach (var error in result.Errors)
            {
                var key = string.IsNullOrEmpty(prefix) ? error.PropertyName : prefix + error.PropertyName;
                controller.ModelState.AddModelError(key, error.ErrorMessage);
            }

            return false;
        }
    }
}
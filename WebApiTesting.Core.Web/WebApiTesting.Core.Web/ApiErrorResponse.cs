using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace WebApiTesting.Core.Web
{
    public class ApiErrorResponse
    {
        public IReadOnlyCollection<string> Error { get; }

        [JsonConstructor]
        public ApiErrorResponse(IEnumerable<string> error)
        {
            Error = ImmutableArray.CreateRange(error ?? Enumerable.Empty<string>());
        }
    }

    public class ApiErrorResponseFactory
    {
        public static ApiErrorResponse Build(ModelStateDictionary modelState)
        {
            var error = modelState
                .SelectMany(entry => entry.Value.Errors)
                .Select(error => error.ErrorMessage);
            var result = new ApiErrorResponse(error);
            return result;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Formatters;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using CustomFiltersAndFormatters.Models;
namespace CustomFiltersAndFormatters.Formatter
{
    public class ImageFormatter : OutputFormatter
    {

        public ImageFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("image/png"));
        }
        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            HttpResponse response = context.HttpContext.Response;
            Value value = context.Object as Value;
            if (value != null)
                await response.SendFileAsync((value).Thumbnail);
        }
    }
}
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using SampleProjects.Models;
using System.Net;
public static class ApplicationBuilderExtensions
{
    #region Example
    //app.UseDeveloperExceptionPage();
    //app.UseExceptionHandler("/Error");
    #endregion

    public static void UseExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseExceptionHandler(c => c.Run(async option =>
            {
                var exception = option.Features
                    .Get<IExceptionHandlerPathFeature>()
                    .Error;
                var response = new { error = exception.Message };
                //await option.Response.WriteAsJsonAsync(response);
                option.Response.Redirect($"/ExceptionHandling/Index?exception=" +
                    $"{exception.Message}&statusCode={option.Response.StatusCode}");
                //await context.Response.WriteAsync(
                //                         "<a href=\"/\">Home</a><br>\r\n");
            }));
        }
        else
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Middleware_404
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware404
    {
        private readonly RequestDelegate _next;

        public Middleware404(RequestDelegate next)
        {
            _next = next;
        }

        async public Task Invoke(HttpContext httpContext)
        {
			await _next(httpContext);

			if(httpContext.Response.StatusCode == 404)
			{
				//httpContext.Response.Clear();
				await httpContext.Response.WriteAsync("Page Not Found");
			}
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Middleware404Extensions
    {
        public static IApplicationBuilder UseMiddleware404(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware404>();
        }
    }
}

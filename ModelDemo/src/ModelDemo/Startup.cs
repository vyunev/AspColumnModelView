﻿using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace ModelDemo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services) {
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app) {
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" });
			});
		}
	}
}
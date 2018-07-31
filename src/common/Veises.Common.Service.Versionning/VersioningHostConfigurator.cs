﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Veises.Common.Service.Versionning
{
	internal sealed class VersioningHostConfigurator: IHostConfigurator
	{
		public Action<IApplicationBuilder> Configure() => builder => { };

		public Action<WebHostBuilderContext, IConfigurationBuilder> ConfigureApp() => (context, config) => { };

		public Action<IServiceCollection> ConfigureServices() => services =>
		{
			services
				.AddMvcCore()
				.AddVersionedApiExplorer(o =>
				{
					o.GroupNameFormat = "'v'VVV";
					o.AssumeDefaultVersionWhenUnspecified = true;
					o.DefaultApiVersion = new ApiVersion(1, 0);
				});

			services.AddApiVersioning(c =>
			{
				c.DefaultApiVersion = new ApiVersion(1, 0);
				c.ReportApiVersions = true;
			});
		};
	}
}
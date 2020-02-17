using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;
using App.Shared.Domain.Bus.UseCase;
using App.Application.UseCase;
using App.Application.Event;
using App.Infrastructure.Persistence.Repository;
using App.Shared.Domain;
using App.Shared.Infrastructure.Bus.UseCase;
using App.Shared.Domain.Bus.Middleware;
using App.Shared.Domain.Bus.Event;
using App.Shared.Infrastructure.Bus.Middleware;


namespace App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<CustomerConverter>();
            services.AddScoped<SignUpCustomerUseCase>();
            services.AddScoped<SendWelcomeEmailWhenUserSignedUpEventHandler>();




            // Domain
            services.AddSingleton<App.Shared.Domain.Bus.Event.EventProvider>();
            
            services.AddScoped<App.Domain.CustomerAggregate.ICustomerFactory, App.Infrastructure.Service.CustomerService.CustomerFactory>();
            services.AddScoped<App.Domain.CustomerAggregate.Service.SignUpCustomerValidator>();




            // Infra
            services.AddScoped<App.Infrastructure.Service.Hashing.IHashing, App.Infrastructure.Service.Hashing.DefaultHashing>();
            services.AddScoped<App.Domain.CustomerAggregate.ICustomerRepository, App.Infrastructure.Persistence.Repository.CustomerRepository>();
            services.AddScoped<App.Infrastructure.Persistence.Context.BlockbusterContext>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddSingleton<App.Shared.Domain.Bus.UseCase.IUseCaseBus, App.Shared.Infrastructure.Bus.UseCase.UseCaseBus>();
            services.AddSingleton<App.Shared.Domain.Bus.Event.IEventBus, App.Shared.Infrastructure.Bus.Event.EventBusSync>();
            

            services.AddSingleton<App.Shared.Infrastructure.Bus.Middleware.TransactionMiddleware>();
            services.AddSingleton<App.Shared.Infrastructure.Bus.Middleware.EventDispatcherSyncMiddleware>();
            




            services.AddMvcCore().AddVersionedApiExplorer(o => o.GroupNameFormat = "'v'VVV");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddApiVersioning(config =>
            {
                config.ReportApiVersions = true;
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });
            services.AddSwaggerGen(
                options =>
                {
                    options.AddSecurityDefinition("oauth2", new ApiKeyScheme
                    {
                        Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                        In = "header",
                        Name = "Authorization",
                        Type = "apiKey"
                    });

                    options.OperationFilter<SecurityRequirementsOperationFilter>();

                    var provider = services.BuildServiceProvider()
                                        .GetRequiredService<IApiVersionDescriptionProvider>();

                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerDoc(
                            description.GroupName,
                            new Info()
                            {
                                Title = $"Sample API {description.ApiVersion}",
                                Version = description.ApiVersion.ToString()
                            });
                    }
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, IApiVersionDescriptionProvider provider, IServiceProvider serviceProvider)
        {

            IUseCaseBus useCaseBus = serviceProvider.GetService<IUseCaseBus>();
            SignUpCustomerUseCase signUpCustomerUseCase = serviceProvider.GetService<SignUpCustomerUseCase>();
            useCaseBus.Subscribe(signUpCustomerUseCase);


            List<IMiddlewareHandler> middlewareHandlers = new List<IMiddlewareHandler>();
            middlewareHandlers.Add(serviceProvider.GetService<TransactionMiddleware>());
            middlewareHandlers.Add(serviceProvider.GetService<EventDispatcherSyncMiddleware>());

            useCaseBus.SetMiddlewares(middlewareHandlers);
            
            

            IEventBus eventBus = serviceProvider.GetService<IEventBus>();
            SendWelcomeEmailWhenUserSignedUpEventHandler sendWelcomeEmailWhenUserSignedUpEventHandler = serviceProvider.GetService<SendWelcomeEmailWhenUserSignedUpEventHandler>();
            eventBus.Subscribe(sendWelcomeEmailWhenUserSignedUpEventHandler, "App.Domain.CustomerAggregate.Event.CustomerSignedUpEvent");
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
                /**app.UseExceptionHandler(errorApp =>
                {
                    errorApp.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        context.Response.ContentType = "text/plain";
                        var errorFeature = context.Features.Get<IExceptionHandlerFeature>();
                        if (errorFeature != null)
                        {
                            var logger = loggerFactory.CreateLogger("Global exception logger");
                            logger.LogError(500, errorFeature.Error, errorFeature.Error.Message);
                        }

                        await context.Response.WriteAsync("There was an error");
                    });
                });**/
            }

            //app.AddSeedData();

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(
                options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                            $"/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                    }
                });

            app.UseCors("AllowAllOrigins");
            

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

//Importante!!! debemos hacer algunos cambios respecto a las clases grabadas

//Cambio 1:
//En el video cargamos algunos servicios como singleton, por ejemplo:
//services.AddSingleton<CraftCodeContext>();
//Todos los servicios se deben añadir con "AddScoped", por ejemplo:
//services.AddScoped<CraftCodeContext>();
//Cambiar el resto de servicios que tengan "AddSingleton"

//Cambio 2:
//En el video cargamos los listeners dentro de la función "Configure"
//El nuevo cambio consiste en cargar los listeners dentro de un middleware para que se carguen para cada request
//Mirar la línea 29

namespace CraftCodeApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApiVersionDescriptionProvider provider, IServiceProvider serviceProvider)
        {
            app.Use((context, next) =>
            {
                IUseCaseBus useCaseBus = context.RequestServices.GetRequiredService<IUseCaseBus>();
                IUseCase signUpUserUseCase = context.RequestServices.GetRequiredService<SignUpUserUseCase>();
                IUseCase welcomeEmailUseCase = context.RequestServices.GetRequiredService<SendUserWelcomeEmailUseCase>();
                IUseCase createTokenUseCase = context.RequestServices.GetRequiredService<CreateTokenUseCase>();
                IUseCase createCourseUseCase = context.RequestServices.GetRequiredService<CreateCourseUseCase>();
                IUseCase getUsersUseCase = context.RequestServices.GetRequiredService<GetUsersUseCase>();
                useCaseBus.Subscribe(signUpUserUseCase);
                useCaseBus.Subscribe(welcomeEmailUseCase);
                useCaseBus.Subscribe(createTokenUseCase);
                useCaseBus.Subscribe(createCourseUseCase);
                useCaseBus.Subscribe(getUsersUseCase);

                List<IMiddlewareHandler> middlewareHandlers = new List<IMiddlewareHandler>
                {
                    context.RequestServices.GetRequiredService<EventDispatcherSyncMiddleware>(),
                    context.RequestServices.GetRequiredService<TransactionMiddleware>(),
                    context.RequestServices.GetRequiredService<ExceptionMiddleware>()
                };

                useCaseBus.SetMiddlewares(middlewareHandlers);

                IEventBus eventBus = context.RequestServices.GetRequiredService<IEventBus>();
                eventBus.Subscribe(context.RequestServices.GetRequiredService<SendWelcomeEmailWhenUserSignedUpEventHandler>(), "user_signed_up");

                return next();
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

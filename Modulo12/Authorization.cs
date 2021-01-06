//1. add to appsettings
"AppSettings": {
    "Secret": "0vTXplbiIiyDh2eEKId0WYYoofzpyoRMWeE0Wc37NN6q8L6uj3bjD0LLEkbqGNtJWdOwdfqIAcV7UTn65Haewyju1WUirO8X0",
    "TokenLifetimeInMinutes": 10080
},

//2. add the following authentication service to startup.cs

var appSettingsSection = Configuration.GetSection("AppSettings");
var secret = Configuration.GetValue<string>("AppSettings:Secret");
var key = Encoding.ASCII.GetBytes(secret);

services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

services.AddOptions();


//3. add the following swagger service to startup.cs

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

//4. add the following content to startup.cs
app.UseAuthentication();

//5. add the following attribute to some controller
[Authorize]
[Authorize(Roles = UserRole.ROLE_ADMIN)]

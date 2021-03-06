//1. Install dependencies
//Install-Package Swashbuckle.AspNetCore -Version 2.4.0
//Install-Package Swashbuckle.AspNetCore.Filters -Version 4.5.3
//Install-Package Microsoft.AspNetCore.Mvc.Versioning -Version 2.2.0
//Install-Package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer -Version 2.2.0


//2.Add the following content to Startup.cs (ConfigureServices method)
/**
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
    }
);
**/

//3.Add the following content to Startup.cs (Configure method)

/**
add (IApiVersionDescriptionProvider provider) as parameter

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
**/
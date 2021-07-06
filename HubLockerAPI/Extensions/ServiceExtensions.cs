using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Data.Data;
using HubLockerAPI.Models.Entities;
using HubLockerAPI.Services.Implementation;
using HubLockerAPI.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HubLockerAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentityPassword(this IServiceCollection services) =>
            services.Configure<IdentityOptions>(options =>
            {
                //options.SignIn.RequireConfirmedEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                // options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;
            });

        public static void ConfigureAddIdentity(this IServiceCollection services) =>
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContextPool<ApplicationDbContext>(config =>
                config.UseSqlServer(configuration.GetConnectionString("ConnStr")).EnableSensitiveDataLogging());
        //config.UseInMemoryDatabase("CommandDb"));


        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Commander.API", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Name = "Bearer",
                        },
                        new List<string>()

                    }

                });
            });

        }
        public static void ConfigureLockerService(this IServiceCollection services) => services.AddScoped<ILockerService, LockerService>();

    }
}

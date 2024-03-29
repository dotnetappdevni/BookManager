
using BookManager.CustomerService.Interface;
using BookManager.Domain;
using BookManager.Services;
using BookManager.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using BookManager.CustomerService.Interface;

using BookManager.CustomerService;
using BookManager.DAL;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using NLog.Web;
using NLog.Extensions.Logging;
using BookManager.API;
using Microsoft.AspNetCore.Identity.UI.Services;
namespace BookManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

             var test = builder.Configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
          
            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationDBContext>(
           options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EDT", Version = "v1.1.2" });
                //   c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                //Expose XML comments in doc.
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description =
                        "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new List<string>()
                }
            });
            });

            builder.Services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddNLog();
            });

            builder.Services.AddFluentEmail(builder.Configuration);
            builder.Services.AddTransient<IEmailService, EmailService>();
            builder.Services.AddTransient<IEmailSender, EmailSender>();

            builder.Services.AddScoped<ICustomerService, CustomerServices>();
            builder.Services.AddScoped<IBookManagerServices, BookManagerServices>();
            builder.Services.AddAuthentication().AddJwtBearer();
            builder.Services.AddAuthorization();

            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDBContext>();
            var app = builder.Build();          
            app.UseSwagger();
            app.UseSwaggerUI();        

            app.UseHttpsRedirection();
            app.MapIdentityApi<IdentityUser>();
            app.UseAuthorization();
            app.UseAuthorization();
            app.MapControllers();
           app.Run();
        }

     
    }
}

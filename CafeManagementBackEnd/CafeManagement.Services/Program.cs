using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Infrastructure.Repositories.RepositoryImplementations;
using CafeManagement.Services.API.Services;
using CafeManagement.Services.API.Services.ServiceImplementations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace CafeManagement.Services.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(30));
            builder.Services.AddDbContext<CoffeeShopManagementContext>();
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IAccountServices, AccountServices>();
            builder.Services.AddScoped<IRoleRepository, RoleRepository>();
            builder.Services.AddScoped<IRoleServices, RoleServices>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            //builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseSession();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            //app.UseSession();
            app.MapControllers();

            app.Run();
        }
    }
}
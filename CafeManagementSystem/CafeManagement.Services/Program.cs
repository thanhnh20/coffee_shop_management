using CafeManagement.Infrastructure.Models;
using CafeManagement.Infrastructure.Repositories;
using CafeManagement.Infrastructure.Repositories.RepositoryImplementations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace CafeManagementSystemBackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<CoffeeShopManagementContext>();
            builder.Services.AddScoped<IAccountRepository,AccountRepository>();
            builder.Services.AddScoped<IRoleRepository,RoleRepository>();
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

            app.UseHttpsRedirection();

            app.UseAuthorization();

            //app.UseSession();
            app.MapControllers();

            app.Run();
        }
    }
}

using DS.Foundation.Configuration.Options;
using JBL.Monitoreo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.Intrinsics.Arm;

namespace JBL.Monitoreo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("appsettings.json");

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var configuration = builder.Configuration;
            var dap = configuration.GetSection("Database").Get<DatabaseAccessPointOptions>();
            if (dap == null) throw new Exception("DatabaseAccessPoint appsetting not found.");
            builder.Services.AddDbContext<DataContext>(optionsBuilder =>
            {
                optionsBuilder.UseMySql(dap.ConnectionString, new MySqlServerVersion(dap.Version));
            });

            var app = builder.Build();

            app.UseSwagger();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

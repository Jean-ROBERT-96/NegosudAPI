using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.EntityFrameworkCore.Extensions;
using NegosudAPI.Data;
using NegosudAPI.Data.Repository;
using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using System.Configuration;

namespace NegosudAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataContext>(opt =>
            {
                opt.UseMySQL(builder.Configuration.GetConnectionString("DBConnexion"));
            }); 
            builder.Services.AddTransient<IDataRepository<Article>, ArticleRepository>();
            builder.Services.AddTransient<IDataRepository<Family>, FamilyRepository>();
            builder.Services.AddTransient<IPurchaseOrderRepository, PurchaseOrderRepository>();
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IDataRepository<Client>, ClientRepository>();
            builder.Services.AddTransient<IDataRepository<Vendor>, VendorRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }

    public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddEntityFrameworkMySQL();
            new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection).TryAddCoreServices();
        }
    }
}
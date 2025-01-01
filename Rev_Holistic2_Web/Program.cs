
using Microsoft.EntityFrameworkCore;
using Rev_Holistic2_Web.Data;
using Rev_Holistic2_Web.Repos.CustomerRepos;
using Rev_Holistic2_Web.Repos.OrderRepos;
using Rev_Holistic2_Web.Repos.ProductRepos;
using Rev_Holistic2_Web.Repos.ShoppingCartRepos;

namespace Rev_Holistic2_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DataContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("Def")));
            builder.Services.AddControllers();
            builder.Services.AddScoped<ICustomer, CustomerRepo>();
            builder.Services.AddScoped<IOrder, OrderRepo>();
            builder.Services.AddScoped<IProduct, ProductRepo>();
            builder.Services.AddScoped<IShopping, ShoppingRepo>();
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
}

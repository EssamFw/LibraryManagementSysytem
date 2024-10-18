using BusinessLayer.Services;
using DataAccessLayer.context;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSysytem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            /*
             * 
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IOrderService, OrderService>();


            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
             */
            builder.Services.AddScoped<ILibrarianService, LibrarianService>();
            builder.Services.AddScoped<ILibrarianRepository, LibrarianRepository>();

            //Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            var conncetionstring = builder.Configuration.GetConnectionString("DefaultConnection");
             builder.Services.AddScoped<ILibrarianService , LibrarianService>();
            builder.Services.AddScoped<ILibrarianRepository , LibrarianRepository>();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(conncetionstring)
                .LogTo(Console.WriteLine ,LogLevel.Information));
            //builder.Services.AddAuthorization();
            //builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
